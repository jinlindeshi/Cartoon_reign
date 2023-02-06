# -*- coding: utf-8 -*-
from excel_exporter import *

define = [
	['ID', 'id', Int()],
	['prefab路径', 'prefab', Str()],
	['最大血量', 'maxHp', Int()],
	['攻击力', 'atk', Int()],
	['防御力', 'def', Int()],
	['阵营', 'side', Int()],
]

config = {
	"source": "角色表.xlsx",
	"sheet": "Sheet1",
	"target": [
		[ET_LUA_PATH + "avatar.lua", "lua"],
		#["./test1.js", "js"],
		#["./test1.json", "json"],
		#["./test1.py", "py"],
	],
	"key": "id"
}
