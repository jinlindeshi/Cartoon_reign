-- 奖池道具表.xlsx:Sheet1
-- id = ID
-- type = 类型
-- toID = 对应ID
-- quality = 品质
-- starLv = 星级
-- inPool = 所属奖池

local poolItem = {}

poolItem.Data = {
	[1] = {id = 1, inPool = {1, 2, 3}, quality = 3, starLv = 5, toID = 1, type = "equip"}, 
	[2] = {id = 2, inPool = {1, 2, 3}, quality = 3, starLv = 5, toID = 2, type = "equip"}, 
	[3] = {id = 3, inPool = {1, 2, 3}, quality = 3, starLv = 5, toID = 3, type = "equip"}, 
	[4] = {id = 4, inPool = {1, 2, 3}, quality = 3, starLv = 5, toID = 4, type = "equip"}, 
	[5] = {id = 5, inPool = {1, 2, 3}, quality = 3, starLv = 5, toID = 5, type = "equip"}, 
	[6] = {id = 6, inPool = {1, 2, 3}, quality = 3, starLv = 5, toID = 6, type = "equip"}, 
	[7] = {id = 7, inPool = {1, 2, 3}, quality = 2, starLv = 3, toID = 7, type = "equip"}, 
	[8] = {id = 8, inPool = {1, 2, 3}, quality = 2, starLv = 3, toID = 8, type = "equip"}, 
	[9] = {id = 9, inPool = {1, 2, 3}, quality = 2, starLv = 3, toID = 9, type = "equip"}, 
	[10] = {id = 10, inPool = {1, 2, 3}, quality = 2, starLv = 3, toID = 10, type = "equip"}, 
	[11] = {id = 11, inPool = {1, 2, 3}, quality = 2, starLv = 3, toID = 11, type = "equip"}, 
	[12] = {id = 12, inPool = {1, 2, 3}, quality = 2, starLv = 3, toID = 12, type = "equip"}, 
	[13] = {id = 13, inPool = {1, 2, 3}, quality = 1, starLv = 1, toID = 13, type = "equip"}, 
	[14] = {id = 14, inPool = {1, 2, 3}, quality = 1, starLv = 1, toID = 14, type = "equip"}, 
	[15] = {id = 15, inPool = {1, 2, 3}, quality = 1, starLv = 1, toID = 15, type = "equip"}, 
	[16] = {id = 16, inPool = {1, 2, 3}, quality = 1, starLv = 1, toID = 16, type = "equip"}, 
	[17] = {id = 17, inPool = {1, 2, 3}, quality = 1, starLv = 1, toID = 17, type = "equip"}, 
	[18] = {id = 18, inPool = {1, 2, 3}, quality = 1, starLv = 1, toID = 18, type = "equip"}, 
	[19] = {id = 19, inPool = {1, 2}, quality = 3, starLv = 5, toID = -2, type = "hero"}, 
}

function poolItem.GetData(id) 
    return poolItem.Data[id] 
end

return poolItem