

---@class Vector2:Vector2
---@field one Vector2 Vector2.New(1,1)
---@field zero Vector2 Vector2.New(0,0)

---@class Vector3:Vector3
---@field one Vector3 Vector3.New(1,1,1)
---@field zero Vector3 Vector3.New(0,0,0)


---@class Color:Color
---@field black Color 纯黑色。RGBA 为 (0, 0, 0, 1)。
---@field blue Color 纯蓝色。RGBA 为 (0, 0, 1, 1)。
---@field clear Color 完全透明。RGBA 为 (0, 0, 0, 0)。
---@field cyan Color 青色。RGBA 为 (0, 1, 1, 1)。
---@field gray Color 灰色。RGBA 为 (0.5, 0.5, 0.5, 1)。
---@field green Color 纯绿色。RGBA 为 (0, 1, 0, 1)。
---@field magenta Color 洋红色。RGBA 为 (1, 0, 1, 1)。
---@field red Color 纯红色。RGBA 为 (1, 0, 0, 1)。
---@field white Color 纯白色。RGBA 为 (1, 1, 1, 1)。
---@field yellow Color 黄色。RGBA 为 (1, 0.92, 0.016, 1)，但该颜色很好看！

Util = LuaFramework.Util;
AppConst = LuaFramework.AppConst;
LuaHelper = LuaFramework.LuaHelper;
ByteBuffer = LuaFramework.ByteBuffer;

resMgr = LuaHelper.GetResManager();
networkMgr = LuaHelper.GetNetManager();
sceneMgr = LuaHelper.GetSceneManager();

HappyFuns = HappyCode.HappyFuns

PointerHandler = Prayer.PointerHandler


WWW = UnityEngine.WWW;
GameObject = UnityEngine.GameObject;
--Color = UnityEngine.Color;
Rect = UnityEngine.Rect;
Sprite = UnityEngine.Sprite;
Shader = UnityEngine.Shader;
Material = UnityEngine.Material;
Screen = UnityEngine.Screen;
Application = UnityEngine.Application;
ScreenCapture = UnityEngine.ScreenCapture;
Camera = UnityEngine.Camera;
SceneManager = UnityEngine.SceneManagement.SceneManager
Input = UnityEngine.Input
Physics = UnityEngine.Physics
Random = UnityEngine.Random

DOTWEEN_EASE = DG.Tweening.Ease ---@type DG.Tweening.Ease
DOTWEEN_LOOP_TYPE = DG.Tweening.LoopType ---@type DG.Tweening.LoopType

---Behavior Desiner
TaskStatus = BehaviorDesigner.Runtime.Tasks.TaskStatus

CameraExtensions = UnityEngine.Rendering.Universal.CameraExtensions ---@type UnityEngine.Rendering.Universal.CameraExtensions
CameraRenderType = UnityEngine.Rendering.Universal.CameraRenderType
RectTransformUtility = UnityEngine.RectTransformUtility
--Time = UnityEngine.Time
DOTween = DG.Tweening.DOTween
LuaObj = require("Prayer.Core.LuaObj")
---UI管理器
UIMgr = require("Manager/UIManager")
---Event管理器
EventMgr = require("Manager/EventManager")
---Panel基类
BasePanel = require("Modules.UI.BasePanel")

Talk = require("Modules.Common.View.Talk")
TalkerConfig = require("Modules.Common.Model.TalkerConfig")

---表格数据
SData = require("Modules.WarScene.Model.SData")