# -*- coding: utf-8 -*-
from excel_exporter import *

define = [
	['ID', 'id', Int()],
	['地图ID', 'mapID', Int()],
	['怪物ID配置', 'monsters', List(Int(), ",")],
]

config = {
	"source": "刷怪点表.xlsx",
	"sheet": "Sheet1",
	"target": [
		[ET_LUA_PATH + "monsterPoint.lua", "lua"],
		#["./test1.js", "js"],
		#["./test1.json", "json"],
		#["./test1.py", "py"],
	],
	"key": "id"
}
