# -*- coding: utf-8 -*-
from excel_exporter import *

define = [
	['奖池ID', 'id', Int()],
	['奖池名字', 'poolName', Str()],
	['按钮图片', 'btnIcon', Str()],
	['prefab', 'prefab', Str()],
	['是否开启', 'flag', Int()],
]

config = {
	"source": "奖池表.xlsx",
	"sheet": "Sheet1",
	"target": [
		[ET_LUA_PATH + "pools.lua", "lua"],
		#["./test1.js", "js"],
		#["./test1.json", "json"],
		#["./test1.py", "py"],
	],
	"key": "id"
}
