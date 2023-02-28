-- 装备表.xlsx:Sheet1
-- id = ID
-- icon = icon
-- name = 名称
-- pos = 部位
-- quality = 品质

local equip = {}

equip.Data = {
	[1] = {icon = "equip_1", id = 1, name = "装备1", pos = 1, quality = 3}, 
	[2] = {icon = "equip_2", id = 2, name = "装备2", pos = 2, quality = 3}, 
	[3] = {icon = "equip_3", id = 3, name = "装备3", pos = 3, quality = 3}, 
	[4] = {icon = "equip_4", id = 4, name = "装备4", pos = 4, quality = 3}, 
	[5] = {icon = "equip_5", id = 5, name = "装备5", pos = 5, quality = 3}, 
	[6] = {icon = "equip_6", id = 6, name = "装备6", pos = 6, quality = 3}, 
	[7] = {icon = "equip_1", id = 7, name = "装备7", pos = 1, quality = 2}, 
	[8] = {icon = "equip_2", id = 8, name = "装备8", pos = 2, quality = 2}, 
	[9] = {icon = "equip_3", id = 9, name = "装备9", pos = 3, quality = 2}, 
	[10] = {icon = "equip_4", id = 10, name = "装备10", pos = 4, quality = 2}, 
	[11] = {icon = "equip_5", id = 11, name = "装备11", pos = 5, quality = 2}, 
	[12] = {icon = "equip_6", id = 12, name = "装备12", pos = 6, quality = 2}, 
	[13] = {icon = "equip_1", id = 13, name = "装备13", pos = 1, quality = 1}, 
	[14] = {icon = "equip_2", id = 14, name = "装备14", pos = 2, quality = 1}, 
	[15] = {icon = "equip_3", id = 15, name = "装备15", pos = 3, quality = 1}, 
	[16] = {icon = "equip_4", id = 16, name = "装备16", pos = 4, quality = 1}, 
	[17] = {icon = "equip_5", id = 17, name = "装备17", pos = 5, quality = 1}, 
	[18] = {icon = "equip_6", id = 18, name = "装备18", pos = 6, quality = 1}, 
}

function equip.GetData(id) 
    return equip.Data[id] 
end

return equip