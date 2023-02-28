---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by likai.
--- DateTime: 2021/5/7 3:15 PM
--- 走格子Avatar
local BehaviorAvatar = require("Modules.WarScene.View.AvatarBase.BehaviorAvatar")
local BehaviorConstants = require("Modules.WarScene.Model.BehaviorConstants")
local AvatarBase = require("Modules.WarScene.View.AvatarBase.AvatarBase")
local WarData = require("Modules.WarScene.Model.WarData")
local DamageManager = require("Modules.WarScene.Manager.DamageManager")
---@class WarAvatar:BehaviorAvatar
---@field New fun(prefabPath:string, data, static:boolean, parent:UnityEngine.Transform):WarAvatar
local WarAvatar = class("WarAvatar", BehaviorAvatar)


WarAvatar.ANI_EVENT_ATTACK_HIT = "attackHit"
WarAvatar.ANI_EVENT_SKILL_HIT = "skillHit"
local BASE_MOVE_SPEED = 5
function WarAvatar:Ctor(prefabPath, data, static, parent)
    WarAvatar.super.Ctor(self, prefabPath, parent)
    self.x = 0
    self.z = 0
    self.data = data or {id=0, hp=100, maxHp=100, side=-1}
    self.headUI = require("Modules.WarScene.View.UI.HeadUI").New(self, Vector2.New(0, 80))
    self.hpBar = require("Modules.WarScene.View.UI.HpBar").New(self.data, self.headUI.transform)
    self.hpBar:Hide()

    self.moving = false
    self.static = static ---是否为不能移动的对象
    self.skillMarkTime = nil ---上次施法的时间
    self.skill = nil ---@type SkillBase

    self.gameObject.name = ""..data.id

    self:RegisterAction(BehaviorConstants.FIND_ENEMY)
    self:RegisterAction(BehaviorConstants.ATTACK)
    self:RegisterAction(BehaviorConstants.TRY_TO_CAST_SKILL)

    self.aniEvent = GetComponent.AnimationEvent(self.gameObject)

    self.seekerToLua = AddOrGetComponent(self.gameObject, SeekerToLua) ---@type SeekerToLua

    if data.skillName then
        self:SetSkill(data.skillName)
    end

    if self.static == true then
        return
    end

    self:RegisterAction(BehaviorConstants.MOVE_TO_ENEMY)
    self:RegisterAction(BehaviorConstants.FOLLOW)

    self.aiPath = AddOrGetComponent(self.gameObject, AIPathToLua) ---@type AIPathToLua
    self.aiPath.maxSpeed = BASE_MOVE_SPEED
    self.aiPath.canSearch = false
    self.aiPath.slowdownDistance = 0
    self.aiPath.endReachedDistance = 0.5
    self.aiPath.whenCloseToDestination = Pathfinding.CloseToDestinationMode.Stop
    self.aiPath.rotationSpeed = 3000
    self.aiPath.slowWhenNotFacingTarget = false
    self.aiPath:SetLuaCallBack(handler(self, self.MoveEnd))
    self:SetAvatarColor()
end

function WarAvatar:SetSkill(name)
    self.skillName = name
    self.skill = require("Modules.WarScene.Controller.Skill.Skill"..self.skillName)
end

function WarAvatar:SetMoveSpeedScale(scale)
    self.aiPath.maxSpeed = BASE_MOVE_SPEED * scale
end

function WarAvatar:RegisterAction(name)
    --print("BehaviorAvatar:RegisterAction", name, require("Modules.WarScene.Controller."..name.."Action"))
    WarAvatar.super.RegisterAction(self, name, require("Modules.WarScene.Controller."..name.."Action"))
end

---施放技能
function WarAvatar:PlaySkillName()
    if not self.skill then
        return
    end
    self.headUI:SkillNameShow(self.skillName)
end

---设置可跟随的队长
---@param avatar WarAvatar
function WarAvatar:SetLeader(avatar)
    self.leader = avatar
end

---开始跟随队长
function WarAvatar:BeginFollow()
    if not self.leader or self.following == true then
        return
    end
    --print("开始跟随")
    self.following = true
    local followFun
    followFun = function()
        if self.following ~= true then
            return
        end
        local leaderAroundGrids = WarData.GetAroundGrids(self.leader.x, self.leader.z)

        if leaderAroundGrids[self.x] and leaderAroundGrids[self.x][self.z] then ---我是否已经在队长周围
            self.followDelay = DelayedCall(0.1, followFun)
            return
        end
        if self.moving == true and leaderAroundGrids[self.x]
                and leaderAroundGrids[self.x][self.z] then ---我是否正在去队长周围
            return
        end

        local x,z,goalPos = WarData.GetAroundNearestGrid(self.transform.position, self.leader.x, self.leader.z,
                nil, true, WarData.AvatarGrids) ---我去最近的队长周围格子

        self:MoveAStar(goalPos, followFun, {x,z})
    end
    followFun()
end

---停止跟随队长
function WarAvatar:EndFollow()
    if self.following ~= true then
        return
    end
    --print("停止跟随")
    self.following = false
    self:StopMoving()
    if self.followDelay then
        StopDelayedCall(self.followDelay)
        self.followDelay = nil
    end
end

function WarAvatar:SetAvatarColor(color, tweenDur, callBack)
    --do return end
    color = color or WarAvatar.DEFAULT_COLOR
    if self.avatarColorTween then
        self.avatarColorTween:Kill()
        self.avatarColorTween = nil
    end
    local oldColor = self.nowColor
    self.nowColor = color
    if not tweenDur then
        Happy.DoWithMaterials(self.gameObject, function(mat)
            --mat.color = color
            mat:SetColor("_Emissive_Color", color)
        end, UnityEngine.SkinnedMeshRenderer)
    else
        self.avatarColorTween = Happy.DOTweenFloat(0, 1, tweenDur, function(value)
            Happy.DoWithMaterials(self.gameObject, function(mat)
                mat:SetColor("_Emissive_Color", Color.Lerp(oldColor, color, value))
                --mat.color = color
            end)
        end, callBack)
    end
end

WarAvatar.HURT_COLOR = Color.New(0.5, 0, 0, 1)
WarAvatar.DEFAULT_COLOR = Color.black
---受伤
function WarAvatar:GetHurt(loseHp, textScale)
    self.data.hp = math.max(0, self.data.hp - loseHp)
    --print("WarAvatar:GetHurt", self.gameObject.name, self.data.hp, debug.traceback())
    self.hpBar:ChangeHp(self.data.hp, self.data.maxHp, true)

    self:SetAvatarColor(WarAvatar.HURT_COLOR)
    DelayedCall(0.1, handler(self, self.SetAvatarColor))

    local effPath = "Effect/Prefabs/fx_role_hit_01.prefab"
    if not self.hitParent then
        self.hitParent = Happy.FindGameObjectLoopFromParent("hit", self.gameObject.transform)
        if not self.hitParent then
            local hitParent = GameObject.New().transform ---@type UnityEngine.Transform
            hitParent.name = "hit"
            hitParent:SetParent(self.transform)
            hitParent.localPosition = Vector3.New(0,1,0)
            self.hitParent = hitParent
        end
    end
    local eff = CreatePrefab(effPath, self.hitParent)
    eff.transform.localPosition = Vector3.zero
    eff.transform.localScale = Vector3.one * 1
    DelayedCall(0.6, function()
        RecyclePrefab(eff, effPath)
    end)

    local path
    if self.data.side == 1 then
        path = "Prefabs/War/FriendBloodText.prefab"
    else
        path = "Prefabs/War/EnemyBloodText.prefab"
    end
    local labelObj = CreatePrefab(path, self.headUI.transform)
    local labelRt = GetComponent.RectTransform(labelObj)
    labelRt.anchoredPosition = self.hpBar.rect.anchoredPosition
    local label = GetComponent.Text(labelObj.transform:Find("text").gameObject)
    label.text = loseHp
    label.transform.localScale = label.transform.localScale * (textScale or 1)
    local cg = GetComponent.CanvasGroup(labelObj)

    ---生成随机坐标
    local randomFixFun = function(v2, h)
        h = h or 20
        return Vector2.New(v2.x + (math.random() - 0.5) * 50,v2.y + (math.random() + 0.5) * h)
    end

    if self.data.side == 1 then
        cg.alpha = 0
        local nativePos = labelRt.anchoredPosition - Vector2.New(0, 30)
        labelRt.anchoredPosition = randomFixFun(labelRt.anchoredPosition, 10)
        cg:DOFade(1, 0.1):OnComplete(function()
            DelayedCall(0.2, function()
                labelRt:DOAnchorPos(nativePos, 0.2)
                cg:DOFade(0, 0.2):OnComplete(function()
                    cg.alpha = 1
                    label.transform.localScale = label.transform.localScale / (textScale or 1)
                    RecyclePrefab(labelObj, path)
                end):SetDelay(0.1)
            end)
        end)
    else
        labelRt.localScale = Vector3.one * 0.7
        labelRt:DOScale(Vector3.one, 0.1):SetEase(DOTWEEN_EASE.OutQuint)

        labelRt:DOAnchorPos(randomFixFun(labelRt.anchoredPosition), 0.2):SetEase(DOTWEEN_EASE.OutQuint):OnComplete(function()
        --labelRt:DOAnchorPosY(labelRt.anchoredPosition.y + 20, 0.3):SetEase(DOTWEEN_EASE.OutQuint):OnComplete(function()
            DelayedCall(0.2, function()
                cg:DOFade(0, 0.1):OnComplete(function()
                    cg.alpha = 1
                    label.transform.localScale = label.transform.localScale / (textScale or 1)
                    RecyclePrefab(labelObj, path)
                end)
            end)
        end)
    end

    local isDead = self.data.hp == 0
    if isDead == true then
        WarData.RemoveAvatar(self)
    end
    return isDead
end

---播放死亡
function WarAvatar:PlayDead()
    if self.playingDead == true then
        return
    end
    self.playingDead = true
    if self.data.side ~= 1 then
        EventMgr.DispatchEvent("MonsterDead", {pos = self.transform.position})
    end
    self:AIStop()
    if self.data.side == WarData.mainAvatar.data.side then
        self:PlayAnimation(AvatarBase.ANI_DEAD_NAME, nil, function()
            self:Recycle()
        end)
    else

        local path = "Effects/Prefabs/fx_die_xiong.prefab"
        local dieEff = CreatePrefab(path, self.transform.parent)
        dieEff.transform.localPosition = self.transform.localPosition
        dieEff.transform.localScale = Vector3.one * 0.5

        local effRender = GetComponent.Renderer(dieEff.transform:Find("Flagments").gameObject)

        local avatarRender = self.gameObject:GetComponentInChildren(typeof(UnityEngine.SkinnedMeshRenderer)) ---@type UnityEngine.Renderer
        effRender.material.mainTexture = avatarRender.material.mainTexture
        DelayedCall(2.5, function()
            RecyclePrefab(dieEff, path)
        end)
        self:Recycle()
    end
end

function WarAvatar:Recycle()
    if self.destroyed == true then
        return
    end
    local doFun = function()
        WarAvatar.super.Recycle(self)
        WarData.RemoveAvatarLoc(self.x, self.z)
        --print("WarAvatar:Recycle 你妹啊", self.x, self.z)
        self.target = nil
        self.hpBar:Recycle()
        self.headUI:Recycle()
    end

    ---主角没了，重生
    if self == WarData.mainAvatar then
        WarData.scene:MyDead(doFun)
    else
        doFun()
    end
end

---验证是否死亡
function WarAvatar:CheckDead()
    return self.playingDead == true
end

function WarAvatar:SetLoc(x, z)
    self.x = x
    self.z = z
    WarData.AddAvatarLoc(self.x, self.z, self.data.id)
end

---设置目标对象
function WarAvatar:SetTarget(target)
    self.target = target ---@type WarAvatar
end

---朝向目标
---@param target WarAvatar
function WarAvatar:LookAtTarget(target)
    target = target or self.target
    if not target then
        return
    end
    local nativePos = self.transform.position
    self.transform.forward = target.transform.position - nativePos

    --local grid = WarData.gridGraph:GetNode(self.x,self.z)
    self.transform.position = nativePos
    self.transform.localEulerAngles = Vector3.New(0,self.transform.localEulerAngles.y,0)
end

---攻击他人
---@param transform UnityEngine.Transform
---@param callBack function
---@param isDead boolean
function WarAvatar:Attack(callBack)
    if not self.target then
        return
    end
    self:LookAtTarget()
    --if self.attackRadius then ---远程攻击
    --    self:RangedAttack(callBack)
    --    return
    --end

    self.aniEvent:SetListenerByMsg(WarAvatar.ANI_EVENT_ATTACK_HIT, function()
        if  self.target then

            if self.attackRadius then ---远程攻击
                self:RangedAttack()
            else
                self.target:GetHurt(DamageManager.GetHurtValue(self.data, self.target.data))
            end
        end
        self.aniEvent:SetListenerByMsg(WarAvatar.ANI_EVENT_ATTACK_HIT, nil)
    end)
    self:PlayAnimation(AvatarBase.ANI_ATTACK_NAME, nil, function()
         --RemoveEventListener(Stage, Event.UPDATE, self.attackUpdate)
        if callBack then
            callBack()
        end
    end)
end

---取消正在进行的攻击
function WarAvatar:CancelAttack()
    self.aniEvent:SetListenerByMsg(WarAvatar.ANI_EVENT_ATTACK_HIT, nil)
    self:PlayAnimation(AvatarBase.ANI_IDLE_NAME)
end

---远程攻击相关信息
function WarAvatar:SetRangedAttackInfo(attackRadius, trailPrefabPath, hitPrefabPath)
    self.attackRadius = attackRadius
    self.trailPrefabPath = trailPrefabPath or "Effect/Prefabs/fx_jian_01.prefab"
    self.hitPrefabPath = hitPrefabPath
end
---远程攻击
function WarAvatar:RangedAttack()
    if not self.bowTran then
        self.bowTran = Happy.FindGameObjectLoopFromParent("bow", self.transform)
    end
    self.trail = CreatePrefab(self.trailPrefabPath)
    self.trail.transform.localScale = Vector3.one
    self.trail.transform.forward = self.target.transform.position - self.transform.position
    self.trail.transform.position = self.bowTran.position
end

function WarAvatar:TrailHit()
    local trail = self.trail
    self.trail = nil

    RecyclePrefab(trail, self.trailPrefabPath)
    if self.target:CheckDead() ~= true then
        self.target:GetHurt(DamageManager.GetHurtValue(self.data, self.target.data))
    end

    if self.hitPrefabPath then
        local hit = CreatePrefab(self.hitPrefabPath)
        hit.transform.position = trail.transform.position
        hit.transform.forward = trail.transform.forward
        DelayedCall(1, function()
            RecyclePrefab(hit, self.hitPrefabPath)
        end)
    end
end

function WarAvatar:Update()
    if self.trail then
        if self.target == nil then
            RecyclePrefab(self.trail, self.trailPrefabPath)
            self.trail = nil
            return
        end
        local lockY = self.trail.transform.position.y
        local nowPos = self.trail.transform.position
        nowPos.y = lockY
        local targetPos = self.target.transform.position
        targetPos.y = lockY
        local dis = Vector3.Distance(nowPos, targetPos)
        local frameSpeed = Time.deltaTime * 16
        self.trail.transform.forward = targetPos - nowPos
        if dis < frameSpeed then
            self.trail.transform.position = targetPos
            self:TrailHit()
        else
            self.trail.transform.position = Vector3.Lerp(nowPos, targetPos, frameSpeed/dis)
        end
    end
end

---移动到指定位置(AStar)
---@param position Vector3 3D坐标 不是格子坐标
function WarAvatar:MoveAStar(position, callBack, lockGridPos)
    if isnull(self.gameObject) == true then
        return
    end

    self:StopMoving(true)
    self.moving = true
    self.movingEndCall = callBack

    WarData.RemoveAvatarLoc(self.x, self.z)
    self:SetLoc(lockGridPos[1], lockGridPos[2])

    self.seekerToLua:TakeMove(position, handler(self, self.GetPath))
end

---@param path Pathfinding.ABPath
function WarAvatar:GetPath(path)
    local nodeList = path.path

    --print("WarAvatar:GetPath 开始", nodeList.Count, self.data.id)

    self.aiPath.updateRotation = true
    self.aiPath.updatePosition = true
    self:PlayAnimation(AvatarBase.ANI_MOVE_NAME, 0)
    self.ani.speed = self.aiPath.maxSpeed/3.5
end

function WarAvatar:MoveEnd()
    --if self.data.id < -1 then
    --    print("你妹 结束移动", self.data.id, self.x, self.z, isForceStop)
    --end
    self.aiPath.updateRotation = false
    self.aiPath.updatePosition = false
    self:PlayAnimation(AvatarBase.ANI_IDLE_NAME, 0)
    self.moving = false
    --print("你妹 结束移动", self.data.id, self.moving)
    self.ani.speed = 1
    if self.movingEndCall then
        local fun = self.movingEndCall
        self.movingEndCall = nil
        fun()
    end
end

function WarAvatar:StopMoving(noMoveEndFun)
    self.aiPath:StopMove()
    if noMoveEndFun ~= true then
        self:MoveEnd()
    end
end

return WarAvatar
