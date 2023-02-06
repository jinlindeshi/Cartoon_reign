-- 角色表.xlsx:Sheet1
-- id = ID
-- prefab = prefab路径
-- maxHp = 最大血量
-- atk = 攻击力
-- def = 防御力
-- side = 阵营

local avatar = {
	[-3] = {atk = 20, def = 5, id = -3, maxHp = 3000, prefab = "Prefabs/Avatars/Kanna2.prefab", side = 1}, 
	[-2] = {atk = 20, def = 5, id = -2, maxHp = 3000, prefab = "Prefabs/Avatars/Kanna.prefab", side = 1}, 
	[-1] = {atk = 40, def = 5, id = -1, maxHp = 5000, prefab = "Prefabs/Avatars/Role.prefab", side = 1}, 
}
return avatar