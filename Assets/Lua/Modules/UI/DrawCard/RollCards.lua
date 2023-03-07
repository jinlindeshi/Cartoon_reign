---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by sunshuo.
--- DateTime: 2023/3/6 17:24
--- 滚动卡牌
local url = "Prefabs/Panel/DrawCard/RollCards.prefab"
---@class UI.DrawCard.RollCards
---@field New fun():UI.DrawCard.RollCards
local RollCards = class("UI.DrawCard.RollCards")
function RollCards:Ctor(parent, moveTime)
    self.gameObject = CreatePrefab(url, parent)
    self.transform = self.gameObject.transform
    self.moveTime = moveTime or 0.8
    self.moveTimeTemp = nil
    self.stopCount = nil
    self:ResetList()
    self:StartMove()
end

function RollCards:ResetList()
    self.itemList = {} ---@type table<number, UnityEngine.Transform>
    self.posList = {}
    for i = 1, self.transform.childCount do
        local tra = self.transform:GetChild(i - 1)
        local pos = tra.localPosition
        table.insert(self.itemList, {tra = tra, index = i})
        table.insert(self.posList, pos)
    end
end

function RollCards:StartMove()
    self.moveList = {}
    self:MoveUpdate()
    self.updateFun = function() self:Update() end
    AddEventListener(Stage, Event.UPDATE, self.updateFun)
end

function RollCards:SetStopCount(count)
    self.stopCount = count
end

function RollCards:SetMoveTime(moveTime)
    self.moveTimeTemp = moveTime
end

---移动更新
function RollCards:MoveUpdate(smooth)
    for i = 1, #self.itemList do
        local item = self.itemList[i]
        local target = self.posList[item.index + 1]
        if target then
            self:MoveItem(item.tra, target, smooth)
            item.index = item.index + 1
        else
            item.tra.localPosition = self.posList[1]
            item.index = 1
        end

    end
end

---单个item进入移动队列
function RollCards:MoveItem(item, pos, smooth)
    table.insert(self.moveList, {startPos = item.localPosition, targetPos = pos, tra = item,
                                 durTime = self.moveTime, startTime = os.clock(), isMove = true, smooth = smooth})
end

function RollCards:CheckMoveList()
    for i = 1, #self.moveList do
        if self.moveList[i].isMove then
            return
        end
    end
    self.moveList = {}
    if self.stopCount ~= nil and self.stopCount >= 0 then
        if self.stopCount == 0 then
            RemoveEventListener(Stage, Event.UPDATE, self.updateFun)
            self.stopCount = nil
        elseif self.stopCount == 1 then
            self.moveTime = 2
            self:MoveUpdate(true)
            self.stopCount = self.stopCount - 1
        else
            self:MoveUpdate()
            self.stopCount = self.stopCount - 1
        end
    elseif self.moveTimeTemp ~= nil and self.moveTimeTemp ~= self.moveTime then
        self.moveTime = self.moveTimeTemp
        self.moveTimeTemp = nil
        self:MoveUpdate()
    else
        self:MoveUpdate()
    end

end

function RollCards:Update()
    for i = 1, #self.moveList do
        local item = self.moveList[i]
        if item.isMove then
            local sinceTime = os.clock() - item.startTime
            local percent = sinceTime / item.durTime
            if item.smooth then
                item.tra.localPosition = Vector2.SmoothDamp(item.startPos, item.targetPos, Vector2.zero, 0.5, nil,percent)
                if percent > 1 then
                    --item.tra.localPosition = item.targetPos
                    item.isMove = false
                    self:CheckMoveList()
                end
            else
                item.tra.localPosition = Vector2.Lerp(item.startPos, item.targetPos, percent)
                if percent > 1 then
                    item.tra.localPosition = item.targetPos
                    item.isMove = false
                    self:CheckMoveList()
                end
            end


        end
    end
end

function RollCards:Recycle()
    RecyclePrefab(self.gameObject, url)
    RemoveEventListener(Stage, Event.UPDATE, self.updateFun)
end

return RollCards