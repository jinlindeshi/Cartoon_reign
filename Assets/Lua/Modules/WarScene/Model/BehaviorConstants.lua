---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by VIVA.
--- DateTime: 2023/1/26 13:14
--- 行为枚举

local BehaviorConstants = {}

BehaviorConstants.FIND_ENEMY = "FindEnemy" ---找到一个敌方目标
BehaviorConstants.MOVE_TO_ENEMY = "MoveToEnemy" ---移动到可攻击敌方目标的格子
BehaviorConstants.ATTACK = "Attack" ---攻击
BehaviorConstants.NEW_WAVE_ENEMYS = "NewWaveEnemys" ---刷新一波怪
BehaviorConstants.CHECK_SAFE = "CheckSafe" ---查询地图上是不是没有敌人，没有的话Sucess，有的话锁定一个最近的
BehaviorConstants.FOLLOW = "Follow" ---跟随队长





return BehaviorConstants