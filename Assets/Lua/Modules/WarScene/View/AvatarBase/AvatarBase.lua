---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by VIVA.
--- DateTime: 2023/2/6 22:13
---
---@class AvatarBase:LuaObj
---@field transform UnityEngine.Transform
---@field gameObject UnityEngine.GameObject
local AvatarBase = class("AvatarBase", LuaObj)

AvatarBase.ANI_MOVE_NAME="move"
AvatarBase.ANI_IDLE_NAME="idle"
AvatarBase.ANI_ATTACK_NAME="attack"
AvatarBase.ANI_SKILL_NAME="skill"
AvatarBase.ANI_DEAD_NAME="dead"
function AvatarBase:Ctor(prefabPath, noController, parent)
    prefabPath = prefabPath or "Prefabs/Avatars/Role.prefab"
    AvatarBase.super.Ctor(self, prefabPath, nil, parent)

    self.speed = 0
    self.direction = self.transform.localEulerAngles.y

    self.ani = self.gameObject:GetComponentInChildren(typeof(UnityEngine.Animator)) ---@type UnityEngine.Animator
    if not self.ani then
        return
    end
    self:PlayAnimation(AvatarBase.ANI_IDLE_NAME)
    if noController ~= true then
        self.cc = AddOrGetComponent(self.gameObject, UnityEngine.CharacterController) ---@type UnityEngine.CharacterController
    end
    self:InitAnimations()
end

---初始化动画时长们
function AvatarBase:InitAnimations()
    local clips = self.ani.runtimeAnimatorController.animationClips
    self.clipLens = {}
    for i = 0, clips.Length - 1 do
        local clip = clips[i] ---@type UnityEngine.AnimationClip
        self.clipLens[clip.name] = clip.length
        --print("AvatarBase:InitAnimations", clip.name)
    end
end

function AvatarBase:PlayAnimation(name, crossTime, callBack)
    if not self.lastAni or self.lastAni == AvatarBase.ANI_IDLE_NAME then
        self.ani:Play(name)
    else
        crossTime = crossTime or 0
        self.ani:CrossFade(name, crossTime)
    end
    self.lastAni = name
    if callBack then
        --print("AvatarBase:PlayAnimation2", name, self.clipLens[name])
        DelayedCall(self.clipLens[name], callBack)
    end
end

function AvatarBase:Recycle()
    AvatarBase.super.Recycle(self)

end

function AvatarBase:OnDestroy()
    --print("AvatarBase:OnDestroy")
end

return AvatarBase