---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by sunshuo.
--- DateTime: 2023/2/7 13:26
--- 角色数据
local SData = require("Modules.WarScene.Model.SData")
local AvatarData = {}

AvatarData.HeroInfo =
{
    {
        id = -1,
        starLv = 1,
        equips =
        {
            {index = 1, equipId = 1},
            {index = 2, equipId = 0},
            {index = 3, equipId = 0},
            {index = 4, equipId = 0},
            {index = 5, equipId = 0},
            {index = 6, equipId = 0},
        }
    }
}

--获取角色数据
function AvatarData.GetHeroData(id)
    for i = 1, #AvatarData.HeroInfo do
        if AvatarData.HeroInfo[i].id == id then
            return AvatarData.HeroInfo[i]
        end
    end
end

function AvatarData.GetHeroAttr(id)
    local data = AvatarData.GetHeroData(id)
    local SData = SData.GetAvatarSData(id)
    
end

return AvatarData