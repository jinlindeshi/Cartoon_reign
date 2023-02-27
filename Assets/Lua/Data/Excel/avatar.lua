-- 角色表.xlsx:Sheet1
-- id = ID
-- prefab = prefab路径
-- name = 名称
-- maxHp = 最大血量
-- atk = 攻击力
-- def = 防御力
-- side = 阵营
-- quality = 品质

local avatar = {}

avatar.Data = {
	[-3] = {atk = 20, def = 5, id = -3, maxHp = 3000, name = "女近战", prefab = "Prefabs/Avatars/Kanna.prefab", quality = 3, side = 1}, 
	[-2] = {atk = 30, def = 5, id = -2, maxHp = 3000, name = "弓箭手", prefab = "Prefabs/Avatars/Archer.prefab", quality = 3, side = 1}, 
	[-1] = {atk = 25, def = 5, id = -1, maxHp = 5000, name = "男主角", prefab = "Prefabs/Avatars/Role.prefab", quality = 3, side = 1}, 
}

function avatar.GetData(id) 
    return avatar.Data[id] 
end

return avatar