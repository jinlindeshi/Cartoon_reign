-- 刷怪点表.xlsx:Sheet1
-- id = ID
-- mapID = 地图ID
-- monsters = 怪物ID配置

local monsterPoint = {}

monsterPoint.Data = {
	[1] = {id = 1, mapID = 1, monsters = {1, 2, 2, 2, 3, 3}}, 
	[2] = {id = 2, mapID = 1, monsters = {1, 3, 3, 3}}, 
	[3] = {id = 3, mapID = 1, monsters = {1, 1, 1}}, 
}

function monsterPoint.GetData(id) 
    return monsterPoint.Data[id] 
end

return monsterPoint