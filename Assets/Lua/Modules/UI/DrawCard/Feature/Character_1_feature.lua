---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by sunshuo.
--- DateTime: 2023/3/1 15:13
---
---@class UI.DrawCard.Character_1_feature
---@field New fun():UI.DrawCard.OpenCardShow
local Character_1_feature = class("UI.DrawCard.Character_1_feature")
local fxUrl = "Effect/Prefabs/fx_starShine.prefab"
local step1_scale = Vector2.New(1.6,1.6)
local step1_start_pos = Vector2.New(80,500)
local step1_end_pos = Vector2.New(80,65)
local step1_fx_pos = Vector2.New(0,-100)
local step2_fx_pos = Vector2.New(0,250)
--local step2_scale = Vector2.New(4,4)

--local step2_fx_pos = Vector2.New(100,250)
function Character_1_feature:Ctor(go, parent, pic,showCb, endCb)
    if type(go) == "string" then
        self.name = go
        self.gameObject = CreatePrefab(go,parent,go.name) ---@type UnityEngine.GameObject
    else
        self.name = go.name
        self.gameObject = ClonePrefab(go,parent,go.name) ---@type UnityEngine.GameObject
    end
    self.transform = self.gameObject.transform
    self.showCb = showCb
    self.endCb = endCb
    self.mask = self.transform:Find("Mask").gameObject
    self.img = GetComponent.Image(self.gameObject)
    self.maskCg = GetComponent.CanvasGroup(self.mask)
    self.cg = GetComponent.CanvasGroup(self.gameObject)
    self.fx = CreatePrefab(fxUrl, self.transform.parent)
    self.img.sprite = resMgr:LoadSpriteAtPath(string.format("%s%s.png", DemoCfg.characterPicPath, pic))
    self.img:SetNativeSize()
    self.fx:SetActive(false)
    self.img.color = Color.white
    self.cg.alpha = 1
    self.maskCg.alpha = 1
    self.transform.localPosition = step1_start_pos
    self.transform.localScale = step1_scale
end

function Character_1_feature:Play()
    self.gameObject:SetActive(true)
    local seq = DOTween.Sequence()
    ---第一阶段特写
    seq:AppendInterval(0.2)
    seq:Append(self.transform:DOLocalMove(step1_end_pos, 4.5))
    seq:Join(self.maskCg:DOFade(0, 0.5))
    seq:InsertCallback(0.7 + 0.5, function()
        self.fx.transform.localPosition = step1_fx_pos
        self.fx:SetActive(true)
    end)
    seq:InsertCallback(0.7 + 2, function()
        self.fx.transform.localPosition = step2_fx_pos
        self.fx:SetActive(false)
        self.fx:SetActive(true)
    end)
    ---结束
    seq:Append(self.transform:DOScale(1, 0.5))
    seq:Join(self.transform:DOLocalMove(Vector2.zero, 0.5))
    seq:AppendInterval(1.5)
    seq:Append(self.maskCg:DOFade(1, 0.2))
    seq:AppendCallback(function()
        self.img.color = Color.New(1,1,1,0)
        if self.showCb then
            self.showCb()
        end
    end)
    seq:Append(self.cg:DOFade(0, 0.25))
    seq:AppendCallback(function()
        RecyclePrefab(self.fx, fxUrl)
        RecyclePrefab(self.gameObject, self.name)
        if self.endCb then
            self.endCb()
        end
    end)
end

return Character_1_feature