-- 奖池表.xlsx:Sheet1
-- id = 奖池ID
-- poolName = 奖池名字
-- btnIcon = 按钮图片
-- prefab = prefab
-- flag = 是否开启

local pools = {}

pools.Data = {
	[1] = {btnIcon = "", flag = 1, id = 1, poolName = "普通奖池", prefab = "NormalPoolControl"}, 
	[2] = {btnIcon = "", flag = 1, id = 2, poolName = "稀有奖池", prefab = "RarePoolControl"}, 
	[3] = {btnIcon = "", flag = 1, id = 3, poolName = "特殊奖池", prefab = "SpecialPoolControl"}, 
}

function pools.GetData(id) 
    return pools.Data[id] 
end

return pools