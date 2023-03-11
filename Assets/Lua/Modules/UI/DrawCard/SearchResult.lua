---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by admin.
--- DateTime: 2023/3/11 14:05
---
local SearchResultItem = require("Modules.UI.DrawCard.SearchResultItem")
local DrawCardModel = require("Modules.UI.DrawCard.Model.DrawCardModel")
local url = "Prefabs/Panel/DrawCard/SearchResult.prefab"
---@class UI.DrawCard.SearchResult
---@field New fun():UI.DrawCard.SearchResult
local SearchResult = class("UI.DrawCard.SearchResult")
function SearchResult:Ctor(parent, endCall)
    self.gameObject = CreatePrefab(url, parent)
    self.transform = self.gameObject.transform
    self.endCall = endCall
    self.points = {}
    for i = 1, 5 do
        local tra = self.transform:Find("point"..i)
        table.insert(self.points, tra)
    end
    self.itemList = {}
    self.resultData,self.featureData = DrawCardModel.GetFiveDrawData()
    self.featureMap = {}
    for i = 1, #self.featureData do
        self.featureMap[self.featureData[i]] = true
    end
    for i = 1, #self.resultData do
        local item = SearchResultItem.New(self.points[i], self.resultData[i])
        item.gameObject:SetActive(false)
        table.insert(self.itemList, item)
    end
    self.isStart = false
    self.startTime = 3
end

function SearchResult:PlayResult()
    local sequence = DOTween.Sequence()
    if self.isStart == false then
        sequence:AppendInterval(self.startTime)
        self.isStart = true
    end
    local isEnd = true
    for i = 1, #self.itemList do
        local item = self.itemList[i]
        if item.isTween == false then
            isEnd = false
            if self.featureMap[item.id] then
                sequence:AppendCallback(function()
                    item:PlayTween(function() self:PlayResult() end)
                end)
                return
            else
                sequence:AppendCallback(function()
                    item:PlayTween()
                end)
                sequence:AppendInterval(0.8)
            end
        end
    end
    if isEnd then
        sequence:AppendCallback(function()
            if self.endCall then
                self.endCall()
            end
        end)
    end
end

function SearchResult:Recycle()
    for i = 1, #self.itemList do
        self.itemList[i]:Recycle()
        self.itemList[i] = nil
    end
    RecyclePrefab(self.gameObject, url)
end

return SearchResult