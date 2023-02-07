---@class BitBenderGames.MobileTouchCamera : BitBenderGames.MonoBehaviourWrapped
---@field CameraAxes BitBenderGames.CameraPlaneAxes
---@field IsAutoScrolling bool
---@field IsPinching bool
---@field IsDragging bool
---@field Cam UnityEngine.Camera
---@field CamZoom float
---@field CamZoomMin float
---@field CamZoomMax float
---@field CamOverzoomMargin float
---@field CamFollowFactor float
---@field AutoScrollDamp float
---@field AutoScrollDampCurve UnityEngine.AnimationCurve
---@field GroundLevelOffset float
---@field BoundaryMin UnityEngine.Vector2
---@field BoundaryMax UnityEngine.Vector2
---@field PerspectiveZoomMode BitBenderGames.PerspectiveZoomMode
---@field EnableRotation bool
---@field EnableTilt bool
---@field TiltAngleMin float
---@field TiltAngleMax float
---@field EnableZoomTilt bool
---@field ZoomTiltAngleMin float
---@field ZoomTiltAngleMax float
---@field RefPlane UnityEngine.Plane
---@field IsSmoothingEnabled bool
---@field CameraScrollVelocity UnityEngine.Vector2
---@field Instance BitBenderGames.MobileTouchCamera
---@field main UnityEngine.Camera
local m = {}
function m:Awake() end
function m:Start() end
function m:OnDestroy() end
function m:ResetCameraBoundaries() end
function m:ResetZoomTilt() end
---@return UnityEngine.Vector3
function m:GetFinger0PosWorld() end
---@param ray UnityEngine.Ray
---@param hitPoint UnityEngine.Vector3
---@return bool
function m:RaycastGround(ray, hitPoint) end
---@param ray UnityEngine.Ray
---@return UnityEngine.Vector3
function m:GetIntersectionPoint(ray) end
---@param ray UnityEngine.Ray
---@return UnityEngine.Vector3
function m:GetIntersectionPointUnsafe(ray) end
---@param testPosition UnityEngine.Vector3
---@return bool
function m:GetIsBoundaryPosition(testPosition) end
---@param newPosition UnityEngine.Vector3
---@param includeSpringBackMargin bool
---@return UnityEngine.Vector3
function m:GetClampToBoundaries(newPosition, includeSpringBackMargin) end
function m:OnDragSceneObject() end
---@return string
function m:CheckCameraAxesErrors() end
---@param v2 UnityEngine.Vector2
---@param offset float
---@return UnityEngine.Vector3
function m:UnprojectVector2(v2, offset) end
---@param v3 UnityEngine.Vector3
---@return UnityEngine.Vector2
function m:ProjectVector3(v3) end
function m:LateUpdate() end
function m:FixedUpdate() end
---@param pos UnityEngine.Vector3
function m:InputControllerOnFingerDown(pos) end
function m:InputControllerOnFingerUp() end
---@param isShowing bool
function m:setDragMode(isShowing) end
---@param isShowing bool
function m:setShopMode(isShowing) end
---@param isShowing bool
function m:setTruckTutorialMode(isShowing) end
function m:OnDrawGizmosSelected() end
BitBenderGames = {}
BitBenderGames.MobileTouchCamera = m
return m