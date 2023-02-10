
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
Color = UnityEngine.Color;
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

---Behavior Desiner
TaskStatus = BehaviorDesigner.Runtime.Tasks.TaskStatus

CameraExtension = UnityEngine.Rendering.Universal.CameraExtension ---@type UnityEngine.Rendering.Universal.CameraExtensions
RectTransformUtility = UnityEngine.RectTransformUtility
--Time = UnityEngine.Time
DOTween = DG.Tweening.DOTween
---UI管理器
UIMgr = require("Manager/UIManager")
---Panel基类
BasePanel = require("Modules.UI.BasePanel")