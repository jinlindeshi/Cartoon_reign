---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by sunshuo.
--- DateTime: 2023/2/6 16:20
---
DemoCfg = {}
DemoCfg.mainAvatarID = -1 ---主角色ID
DemoCfg.mapID = 1 ---地图ID
DemoCfg.followerID = -2 ---随从ID

DemoCfg.starUpRateMap =  ---星级提升 属性上升倍率
{
    [1] = 1,
    [2] = 1.5,
    [3] = 1.8,
    [4] = 2.2,
    [5] = 2.5
}

DemoCfg.rewardData =
{
    {vid = 1, id = 1},{vid = 2, id = 2},{vid = 3, id = 3},
    {vid = 4, id = 4},{vid = 5, id = 5},{vid = 6, id = 6},
    {vid = 7, id = 7},{vid = 8, id = 8},
}

DemoCfg.equipIconPath = "Textures/equip/"
DemoCfg.equipQuality = ---品质
{
    white = 1, --白色
    green = 2, --绿色
    purple = 3, --紫色
}

DemoCfg.qualityBgMap =
{
    [DemoCfg.equipQuality.white] = "Textures/item/bg_baowu_hui_00.png",
    [DemoCfg.equipQuality.green] = "Textures/item/bg_baowu_green_01.png" ,
    [DemoCfg.equipQuality.purple] = "Textures/item/bg_baowu_pur_02.png" ,
}


return DemoCfg