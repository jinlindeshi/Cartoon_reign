-- 怪物表.xlsx:Sheet1
-- id = ID
-- prefab = prefab路径
-- name = 名称
-- maxHp = 最大血量
-- atk = 攻击力
-- def = 防御力
-- side = 阵营

local monster = {
	[1] = {atk = 20, def = 0, id = 1, maxHp = 150, name = "熊", prefab = "Prefabs/Avatars/monster_xiong.prefab", side = 2}, 
	[2] = {atk = 15, def = 0, id = 2, maxHp = 100, name = "狗", prefab = "Prefabs/Avatars/monster_01.prefab", side = 2}, 
	[3] = {atk = 15, def = 0, id = 3, maxHp = 100, name = "花", prefab = "Prefabs/Avatars/monster_02.prefab", side = 2}, 
}
return monster