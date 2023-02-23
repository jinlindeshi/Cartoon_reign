---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by admin.
--- DateTime: 2023/2/23 18:15
---
local TeamModel = {}
TeamModel.eventDefine =
{
    autoAddTeam = "autoAddTeam", --进队
    removeTeam = "removeTeam", --离队
}

TeamModel.HeroSlotMap = ---英雄队列map
{
    [1] = {id = DemoCfg.mainAvatarID, lock = false},
    [2] = {id = nil, lock = false},
    [3] = {id = nil, lock = true},
    [4] = {id = nil, lock = true},
}

function TeamModel.CheckInTeam(id)
    for _, info in pairs(TeamModel.HeroSlotMap) do
        if info.id == id then
            return true
        end
    end
    return false
end

return TeamModel
