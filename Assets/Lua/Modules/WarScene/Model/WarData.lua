---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by likai.
--- DateTime: 2021/12/6 14:17
--- 战斗数据


local WarData = {}

WarData.bornNodes = {{56,47},{56,46},{57,47},{57,46},{55,46}} ---我方出生点

WarData.patrolNodePath = {{46,49},{68,38},{48,32},{29,40},{9,46},{25,69},{44,76}} ---刷怪点
WarData.patrolNodeIndex = -1

WarData.AvatarHash = {}
WarData.AvatarGrids = {}
WarData.gridGraph = nil ---@type Pathfinding.GridGraph
WarData.scene = nil ---@type WarScene

WarData.avatarIdIndex = 0

WarData.mainAvatar = nil ---@type FocusAvatar 当前的主角色

function WarData.AddAvatarLoc(x,z, id)
    if not WarData.AvatarGrids[x] then
        WarData.AvatarGrids[x] = {}
    end
    WarData.AvatarGrids[x][z] = id
end

function WarData.RemoveAvatarLoc(x,z)
    if not WarData.AvatarGrids[x] or not WarData.AvatarGrids[x][z] then
        return
    end
    WarData.AvatarGrids[x][z] = nil
end

---@param avatar WarAvatar
function WarData.AddAvatar(avatar, data)
    WarData.AvatarHash[data.id] = avatar
end

function WarData.RemoveAvatar(avatar)

    WarData.AvatarHash[avatar.data.id] = nil
    avatar:PlayDead()
end

function WarData.GetAvatarById(id)
    return WarData.AvatarHash[id]
end

function WarData.GetAvatarByLoc(x,z)
    --print("你妹啊~",x,z)
    if not WarData.AvatarGrids[x] or not WarData.AvatarGrids[x][z] then
        return nil
    end
    return WarData.AvatarHash[WarData.AvatarGrids[x][z]]
end

---返回两个Avatar之间的距离
---@param fromAvatar WarAvatar
function WarData.GetAvatarDistance(fromAvatar, toAvatar)
    local fromP = SeekerToLua.IntToVector(WarData.gridGraph:GetNode(fromAvatar.x,fromAvatar.z).position)
    local toP = SeekerToLua.IntToVector(WarData.gridGraph:GetNode(toAvatar.x,toAvatar.z).position)

    return Vector3.Distance(fromP, toP)
end

local aroundLoc = {{1,-1},{0,-1},{-1,-1},{-1,0},{-1,1},{0,1},{1,1},{1,0}}
---获取以指定格子为中心 周围格子坐标
function WarData.GetAroundGrids(x, z, radius, checkWalkable, grids, saveCenter, log)
    radius = radius or 1
    grids =  grids or {}
    radius = math.max(radius - 1, 0)
    local newGridList = {}
    for i = 1, #aroundLoc do
        local plus = aroundLoc[i]
        local newX = x + plus[1]
        local newZ = z + plus[2]
        --print("WarData.GetAroundGrids", newX, newZ)
        if checkWalkable ~= true or WarData.gridGraph:GetNode(newX, newZ).Walkable == true then
            if not grids[newX] then
                grids[newX] = {}
            end
            grids[newX][newZ] = true
            table.insert(newGridList, {newX, newZ})
        end
        if radius > 0 then
            --if log == true then
            --    print("WarData.GetAroundGrids 你妹啊~", radius)
            --end
            grids = WarData.GetAroundGrids(newX, newZ, radius, checkWalkable, grids, true)
        end
    end

    if saveCenter ~= true and grids[x] and grids[x][z] then
        grids[x][z] = nil
    end
    return grids
end

---获得目标周围离我最近的格子
---@return number, number, Vector3
function WarData.GetAroundNearestGrid(myPosition, targetX, targetZ, radius, checkWalkable, blackList)
    local grids = WarData.GetAroundGrids(targetX, targetZ, radius, checkWalkable)
    blackList = blackList or {}

    local distance,goalX,goalZ,goalPosition
    for x, tb in pairs(grids) do
        for z, v in pairs(tb) do
            if not blackList[x] or not blackList[x][z] then
                local pos = SeekerToLua.IntToVector(WarData.gridGraph:GetNode(x,z).position)
                local dis = Vector3.Distance(myPosition, pos)
                if not distance or dis < distance then
                    distance = dis
                    goalX = x
                    goalZ = z
                    goalPosition = pos
                end
            end
        end
    end

    return goalX,goalZ,goalPosition,grids
end

return WarData