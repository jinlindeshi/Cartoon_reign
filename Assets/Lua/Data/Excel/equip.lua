-- 装备表.xlsx:Sheet1
-- id = ID
-- icon = icon
-- name = 名称
-- pos = 部位
-- quality = 品质

local equip = {}

equip.Data = {
	[1] = {icon = "equip_1", id = 1, name = "装备", pos = 1, quality = 3}, 
	[2] = {icon = "equip_2", id = 2, name = "装备", pos = 2, quality = 3}, 
	[3] = {icon = "equip_3", id = 3, name = "装备", pos = 3, quality = 3}, 
	[4] = {icon = "equip_4", id = 4, name = "装备", pos = 4, quality = 3}, 
	[5] = {icon = "equip_5", id = 5, name = "装备", pos = 5, quality = 3}, 
	[6] = {icon = "equip_6", id = 6, name = "装备", pos = 6, quality = 3}, 
	[7] = {icon = "equip_1", id = 7, name = "装备", pos = 1, quality = 1}, 
	[8] = {icon = "equip_2", id = 8, name = "装备", pos = 2, quality = 1}, 
	[9] = {icon = "equip_3", id = 9, name = "装备", pos = 3, quality = 1}, 
	[10] = {icon = "equip_4", id = 10, name = "装备", pos = 4, quality = 1}, 
	[11] = {icon = "equip_5", id = 11, name = "装备", pos = 5, quality = 1}, 
	[12] = {icon = "equip_6", id = 12, name = "装备", pos = 6, quality = 1}, 
}

function equip.GetData(id) 
    return equip.Data[id] 
end

return equip