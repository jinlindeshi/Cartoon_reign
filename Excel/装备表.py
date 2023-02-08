# -*- coding: utf-8 -*-
from excel_exporter import *

define = [
	['ID', 'id', Int()],
	['icon', 'icon', Str()],
	['名称', 'name', Str()],
	['部位', 'pos', Int()],
	['品质', 'quality', Int()],
]

config = {
	"source": "装备表.xlsx",
	"sheet": "Sheet1",
	"target": [
		[ET_LUA_PATH + "equip.lua", "lua"],
		#["./test1.js", "js"],
		#["./test1.json", "json"],
		#["./test1.py", "py"],
	],
	"key": "id"
}
