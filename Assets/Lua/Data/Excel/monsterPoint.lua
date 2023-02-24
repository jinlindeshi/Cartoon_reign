-- 刷怪点表.xlsx:Sheet1
-- id = ID
-- mapID = 地图ID
-- monsters = 怪物ID配置

local monsterPoint = {}

monsterPoint.Data = {
	[1] = {id = 1, mapID = 1, monsters = {2, 2, 2, 2, 2, 1}}, 
	[2] = {id = 2, mapID = 1, monsters = {2, 2, 2, 2, 3, 3, 3}}, 
	[3] = {id = 3, mapID = 1, monsters = {3, 3, 3, 3, 3, 1}}, 
	[4] = {id = 4, mapID = 1, monsters = {2, 2, 3, 3, 3, 3, 3}}, 
	[5] = {id = 5, mapID = 1, monsters = {3, 3, 2, 2, 2, 2}}, 
	[6] = {id = 6, mapID = 1, monsters = {1, 1, 2, 2, 3, 3}}, 
}

function monsterPoint.GetData(id) 
    return monsterPoint.Data[id] 
end

return monsterPoint