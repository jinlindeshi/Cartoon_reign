---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by likai.
--- DateTime: 2020-06-01 14:46
--- 测试用 多格拖放包裹

local LuaObj = require("Prayer.Core.LuaObj")
local TestBag = class("TestBag", LuaObj)


local GRID_WIDTH = 100
local GRID_HEIGHT = 100

local GRID_NUM_H = 4
local GRID_NUM_V = 4

function TestBag:Ctor(parent)
    --print("TestBag:Ctor")
    TestBag.super.Ctor(self, "Prefabs/Test/TestBag.prefab", nil, parent)

    self.gridsTran = self.transform:Find("Bg/grids")
    self.gridsHash = {}
    for i = 1, 16 do
        local grid = CreatePrefab("Prefabs/Test/TestGrid.prefab", self.gridsTran)
        local rect = GetComponent.RectTransform(grid)
        local gridText = GetComponent.Text(grid.transform:Find("Text").gameObject)
        local hehe = i
        DelayedFrameCall(function ()
            --print("你妹啊~~", hehe, rect.anchoredPosition.x, rect.anchoredPosition.y)
            local gridX = rect.anchoredPosition.x/GRID_WIDTH
            local gridY = rect.anchoredPosition.y/GRID_HEIGHT
            gridText.text = ""..gridX..","..gridY
            if not self.gridsHash[gridX] then
                self.gridsHash[gridX] = {}
            end
            self.gridsHash[gridX][gridY] = grid
            if hehe == 16 then
                self:InitGridsOver()
            end

        end, 2)

    end
end

function TestBag:InitGridsOver()
    ---放一个物品进去
    --self:PutItemIn("TestItem", {gridX=0, gridY=0, width=1, height=2})
    self:PutItemIn("TestItem2", {gridX=1, gridY=1, width=2, height=2})
end

function TestBag:PutItemIn(pic, gridInfo)
    local item = CreatePrefab("Prefabs/Test/"..pic..".prefab", self.transform:Find("Bg"))
    local itemRt = GetComponent.RectTransform(item)
    --local v = Vector2.New(-GRID_WIDTH, GRID_HEIGHT)
    local gridRt = GetComponent.RectTransform(self.gridsHash[gridInfo.gridX][gridInfo.gridY])
    --print("TestBag:PutItemIn", gridRt.anchoredPosition.x, gridRt.anchoredPosition.y)
    itemRt.anchoredPosition = gridRt.anchoredPosition
    require("Prayer.Utils.DragHelper").New(item, itemRt, function ()
        self:ItemDraging(item, gridInfo)
    end, function () self:ItemDragEnd(item, gridInfo) end)


end
---左上
function TestBag:GetGrids1(gridX, gridY, width, height)
    local leftDownX = gridX
    local leftDownY = gridY - height + 1
    local grids = {}

    for i = 1, width do
        local gX = leftDownX + i - 1
        for j = 1, height do
            local gY = leftDownY + j - 1
            table.insert(grids, {gX, gY})
        end
    end
    return grids
end
---左下
function TestBag:GetGrids2(gridX, gridY, width, height)
    local leftDownX = gridX
    local leftDownY = gridY
    local grids = {}
    for i = 1, width do
        local gX = leftDownX + i - 1
        for j = 1, height do
            local gY = leftDownY + j - 1
            table.insert(grids, {gX, gY})
        end
    end
    return grids
end
---右上
function TestBag:GetGrids3(gridX, gridY, width, height)
    local leftDownX = gridX - width + 1
    local leftDownY = gridY - height + 1
    local grids = {}
    for i = 1, width do
        local gX = leftDownX + i - 1
        for j = 1, height do
            local gY = leftDownY + j - 1
            table.insert(grids, {gX, gY})
        end
    end
    return grids
end
---右下
function TestBag:GetGrids4(gridX, gridY, width, height)
    local leftDownX = gridX - width + 1
    local leftDownY = gridY
    local grids = {}
    for i = 1, width do
        local gX = leftDownX + i - 1
        for j = 1, height do
            local gY = leftDownY + j - 1
            table.insert(grids, {gX, gY})
        end
    end
    return grids
end


local normalColor = Color.New(67/255, 163/255, 241/255, 1)

---拖动中
function TestBag:ItemDraging(item, gridInfo)
    local itemRt = GetComponent.RectTransform(item)
    local itemRect = Rect.New(itemRt.anchoredPosition.x, itemRt.anchoredPosition.y,
            itemRt.sizeDelta.x, itemRt.sizeDelta.y)

    local points = {} ---左上 左下 右上 右下
    table.insert(points, Vector2.New(itemRt.anchoredPosition.x,
            itemRt.anchoredPosition.y + itemRt.sizeDelta.y))
    table.insert(points, Vector2.New(itemRt.anchoredPosition.x, itemRt.anchoredPosition.y))
    table.insert(points, Vector2.New(itemRt.anchoredPosition.x + itemRt.sizeDelta.x,
            itemRt.anchoredPosition.y + itemRt.sizeDelta.y))
    table.insert(points, Vector2.New(itemRt.anchoredPosition.x + itemRt.sizeDelta.x,
            itemRt.anchoredPosition.y))
    --print("TestBag:ItemDraging", leftUp.x, leftUp.y, leftDown.x, leftDown.y)

    local tests = {}
    for i = 1, #points do
        local info = self:PointCheckGrid(points[i], itemRect)
        if info then
            info.index = i
            table.insert(tests, info)
        end
    end
    table.sort(tests, function (a, b)
        return a.area > b.area
    end)

    if self.coloredGrids then
        for i = 1, #self.coloredGrids do
            local gridRt = GetComponent.RectTransform(self.gridsHash[self.coloredGrids[i][1]][self.coloredGrids[i][2]])
            local img = GetComponent.Image(gridRt:Find("Image").gameObject)
            img.color = normalColor
        end
    end

    if #tests == 0 then
        return
    end
    --print("TestBag:ItemDraging", #tests)
    self.coloredGrids = self["GetGrids"..tests[1].index](self, tests[1].gridX, tests[1].gridY,
            gridInfo.width, gridInfo.height)

    ---查验格子坐标是否溢出
    for i = 1, #self.coloredGrids do

        local gridX = self.coloredGrids[i][1]
        local gridY = self.coloredGrids[i][2]

        if (gridX < 0 or gridX >= GRID_NUM_H) or (gridY < 0 or gridY >= GRID_NUM_V) then
            self.coloredGrids = nil
            return
        end
    end

    for i = 1, #self.coloredGrids do
        local gridX = self.coloredGrids[i][1]
        local gridY = self.coloredGrids[i][2]
        --print("TestBag:ItemDraging", #tests)
        --print("TestBag:ItemDraging"..i, gridX, gridY)
        local gridRt = GetComponent.RectTransform(self.gridsHash[gridX][gridY])
        local img = GetComponent.Image(gridRt:Find("Image").gameObject)
        img.color = Color.green
    end
end

---物品拖放结束
function TestBag:ItemDragEnd(item, gridInfo)
    local grid
    if self.coloredGrids and #self.coloredGrids > 0 then
        for i = 1, #self.coloredGrids do
            local gridRt = GetComponent.RectTransform(self.gridsHash[self.coloredGrids[i][1]][self.coloredGrids[i][2]])
            local img = GetComponent.Image(gridRt:Find("Image").gameObject)
            img.color = normalColor
        end

        grid = GetComponent.RectTransform(self.gridsHash[self.coloredGrids[1][1]][self.coloredGrids[1][2]])
    else
        grid = GetComponent.RectTransform(self.gridsHash[gridInfo.gridX][gridInfo.gridY])
    end
    GetComponent.RectTransform(item).anchoredPosition = grid.anchoredPosition
end

---验证坐标点所在的格子坐标 并算出该格子与物体格子相交面积
---@param itemRect UnityEngine.Rect
function TestBag:PointCheckGrid(p, itemRect)
    if p.x < 0 or p.x > GRID_NUM_H * GRID_WIDTH then
        return nil
    end
    if p.y < 0 or p.y > GRID_NUM_V * GRID_HEIGHT then
        return nil
    end

    local gridX = math.floor(p.x/GRID_WIDTH)
    local gridY = math.floor(p.y/GRID_HEIGHT)
    print("TestBag:PointCheckGrid", gridX, gridY)
    local gridRt = GetComponent.RectTransform(self.gridsHash[gridX][gridY])
    local gridRect = Rect.New(gridRt.anchoredPosition.x, gridRt.anchoredPosition.y,
            gridRt.sizeDelta.x, gridRt.sizeDelta.y) ---@type UnityEngine.Rect


    local intersectionWidth = math.min(itemRect.x + itemRect.width, gridRect.x + gridRect.width)
            - math.max(itemRect.x, gridRect.x)
    local intersectionHeight = math.min(itemRect.y + itemRect.height, gridRect.y + gridRect.height)
            - math.max(itemRect.y, gridRect.y)
    --print("TestBag:PointCheckGrid1", p.x, p.y, gridX, gridY)
    --print("TestBag:PointCheckGrid2", itemRect.x, itemRect.y, gridRect.x, gridRect.y, intersectionWidth * intersectionHeight)
    return {gridX = gridX, gridY = gridY, area = intersectionWidth * intersectionHeight}
    --p = p.x + GRID_WIDTH
    --p.x/GRIDX
end


return TestBag