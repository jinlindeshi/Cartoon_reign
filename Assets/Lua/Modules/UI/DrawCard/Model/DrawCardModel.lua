---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by admin.
--- DateTime: 2023/2/20 17:56
---
local DrawCardModel = {}
DrawCardModel.eventDefine =
{
    oneDraw = "DrawCardOne", --单抽
    tenDraw = "DrawCardTen", --十连
    selectPool = "DrawCardPoolSelect", --选择卡池
    checkOpen = "DrawCardCheckOpen", --检测是否所有的卡都已经翻开
    showResult = "showResult",--展示抽卡结果
    activeClick = "activeClick",--控制是否可以点击
}

function DrawCardModel.GetOneDrawData()
    return {5}
end

function DrawCardModel.GetTenDrawData()
    --require("Modules.WarScene.Model.AvatarData").AddHeroData(DemoCfg.followerID)
    return {13,14,15,16,19,13,7,14,18,17}
end

return DrawCardModel