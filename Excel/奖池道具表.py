# -*- coding: utf-8 -*-
from excel_exporter import *

define = [
	['ID', 'id', Int()],
	['类型', 'type', Str()],
	['对应ID', 'toID', Int()],
	['品质', 'quality', Int()],
	['星级', 'starLv', Int()],
	['所属奖池', 'inPool', List(Int(), ",")],
]

config = {
	"source": "奖池道具表.xlsx",
	"sheet": "Sheet1",
	"target": [
		[ET_LUA_PATH + "poolItem.lua", "lua"],
		#["./test1.js", "js"],
		#["./test1.json", "json"],
		#["./test1.py", "py"],
	],
	"key": "id"
}
