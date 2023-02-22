---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by likai.
--- DateTime: 2021/11/18 9:39
--- 战场场景

local WarAvatar = require("Modules.WarScene.View.WarAvatar")
local FocusAvatar = require("Modules.WarScene.View.FocusAvatar")
local LuaScene = require("Prayer.Core.LuaScene")
local WarData = require("Modules.WarScene.Model.WarData")
local SData = require("Modules.WarScene.Model.SData")
local AvatarData = require("Modules.WarScene.Model.AvatarData")


---@class WarScene:LuaScene
local WarScene = class("WarScene", LuaScene)

function WarScene:Ctor(scene)
    --print("WarScene:Ctor", scene)
    WarScene.super.Ctor(self, scene)
    WarData.scene = self

    LuaHelper.AddCameraToStackList(self.mainCamera, GetComponent.Canvas(Game.UICanvas).worldCamera, true)

    self.avatarLoc = {}
    WarData.gridGraph = AstarPath.active.graphs[0] ---@type Pathfinding.GridGraph
    --AstarPath.active.logPathResults = Pathfinding.PathLog.Normal
    AstarPath.active.logPathResults = Pathfinding.PathLog.None

    ---编辑器模式下生成坐标展示
    if Application.isEditor == true then
        self:GenerateGrids()
    end
    self.locContainer:SetActive(false) ---默认是否显示格子
    self.happyCam = GetComponent.HappyCamera(Camera.main.gameObject)

    self.avatarConTran = self:GetRootObjByName("AvatarCon").transform
    self.avatarList = {} --角色列表
    self:TestFocusAvatar()
    UIMgr.OpenPanel(UIPanelCfg.mainMenu)

    --DelayedCall(1, function()
    --    Happy.MainCameraBlurToggle(true, 1)
    --    DelayedCall(4, function()
    --        Happy.MainCameraBlurToggle(false, 1)
    --    end)
    --end)
    --DelayedCall(1, function()
    --    Talk.Play(TalkerConfig.Bear, {"我是杀不完的"
    --    ,"一波一波无穷尽"}, function()
    --        Talk.Play(TalkerConfig.Me2D, {"跟你拼啦！"}, function()
    --            print("播放完毕~")
    --        end)
    --    end)
    --end)
end

---TEST 测试相机跟随Avatar
function WarScene:TestFocusAvatar()
    self:AddAvatar(DemoCfg.mainAvatarID, true).skill = require("Modules.WarScene.Controller.Skill.SkillWhirlwind").New()
    self:AddAvatar(DemoCfg.followerID):SetRangedAttackInfo(2)

end
---TEST

local testBossData = {atk = 75, def = 5, hp = 10000, maxHp = 10000, name = "金刚熊", prefab = "Prefabs/Avatars/monster_xiong.prefab", side = 2}
---挑战BOSS
function WarScene:ChallengeBoss()
    print("WarScene:ChallengeBoss 挑战BOSS")
    WarData.StopAllAvatarAI()

    ---@param avatar WarAvatar
    for id, avatar in pairs(WarData.AvatarHash) do
        if avatar.data.side ~= WarData.mainAvatar.data.side then
            DelayedFrameCall(function()
                WarData.RemoveAvatar(avatar)
            end)
        else
            avatar:SetMoveSpeedScale(3)
            avatar.moveEndSpeedResume = true
        end
    end

    WarData.avatarIdIndex = WarData.avatarIdIndex + 1
    testBossData.id = WarData.avatarIdIndex
    local avatar = WarAvatar.New(testBossData.prefab,
            testBossData, false, WarData.scene.avatarConTran)
    avatar:SetExternalBehavior("BehaviorTree/EnemyAI.asset")
    WarData.AddAvatar(avatar, avatar.data)
    WarData.scene:PutInNode(avatar, WarData.bossNode[1], WarData.bossNode[2])
    avatar.transform.localScale = avatar.transform.localScale * 1.5
    HappyFuns.SetLayerRecursive(avatar.gameObject, 11)

    DelayedCall(2, function()
        WarData.StartAllAvatarAI()
    end)
end

---@param id number 角色ID
---@param isMainRole boolean 是否是主要角色
---@return WarAvatar
function WarScene:AddAvatar(id, isMainRole)
    local myData = clone(SData.avatar.GetData(id))
    local attr = AvatarData.GetHeroAttr(id)
    myData.hp = attr.maxHp
    myData.maxHp = attr.maxHp
    myData.atk = attr.atk
    myData.def = attr.def
    local avatar---@type WarAvatar
    if isMainRole then
        avatar = FocusAvatar.New(myData.prefab, myData, self.avatarConTran)
        WarData.mainAvatar = avatar
        self.happyCam:SetAttachObj(avatar.gameObject)
        avatar:SetExternalBehavior("BehaviorTree/MeAI.asset")
    else
        avatar = WarAvatar.New(myData.prefab, myData, false, self.avatarConTran)
        avatar:SetLeader(WarData.mainAvatar)
        avatar:SetExternalBehavior("BehaviorTree/Follower.asset")
    end
    WarData.AddAvatar(avatar, avatar.data)
    local loc = WarData.bornNodes[-id]
    self:PutInNode(avatar, loc[1], loc[2])
    HappyFuns.SetLayerRecursive(avatar.gameObject, 11)
    avatar:AIStart()

    return avatar
end


---@param avatar WarAvatar
function WarScene:PutInNode(avatar, x, z, obstacle, radius)
    radius = radius or 0
    local grid = WarData.gridGraph:GetNode(x,z)
    avatar:SetLoc(x,z)
    local pos = SeekerToLua.IntToVector(grid.position)

    --print("WarScene:PutInNode", pos.x, pos.y, pos.z)
    avatar.transform.position = Vector3.New(pos.x, pos.y + 0.01, pos.z)
    if obstacle == true then
        local moreGrids = WarData.GetAroundGrids(x,z,radius)
        for moreX, moreZs in pairs(moreGrids) do
            for moreZ, hehe in pairs(moreZs) do
                --print("WarScene:PutInNode", moreX, moreZ)
                local moreGrid = WarData.gridGraph:GetNode(moreX,moreZ)
                moreGrid.Walkable = false
            end
        end
    end
    if not self.avatarLoc[x] then
        self.avatarLoc[x] = {}
    end
    self.avatarLoc[x][z] = avatar
end

function WarScene:GenerateGrids()

    self.locContainer = self:GetRootObjByName("LocContainer") ---@type UnityEngine.GameObject

    local gridsWidth = WarData.gridGraph.width
    local gridsDepth = WarData.gridGraph.depth
    self.gridHash = {}
    for x = 0, gridsWidth-1 do
        for z = 0, gridsDepth-1 do
            local node = WarData.gridGraph:GetNode(x, z) ---@type Pathfinding.GridNode
            if node.Walkable == true then
                local grid = CreatePrefab("Prefabs/War/LocText.prefab", self.locContainer.transform)

                if not self.gridHash[x] then
                    self.gridHash[x] = {}
                end
                self.gridHash[x][z] = grid
                grid.transform.localPosition = SeekerToLua.IntToVector(node.position)
                local tm = GetComponent.TextMesh(grid)
                tm.text = ""..node.XCoordinateInGrid..","..node.ZCoordinateInGrid
                tm.fontSize = 30
                tm.characterSize = 0.1
                grid.name = tm.text
            end
        end
    end
end

return WarScene