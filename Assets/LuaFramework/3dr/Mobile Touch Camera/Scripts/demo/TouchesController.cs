using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

namespace BitBenderGames
{

	public class TouchesController : MonoBehaviour
	{
		
		public TouchInputController touchInputController;

		public MobileTouchCamera mobileTouchCamera;

		public MobilePickingController mobilePickingController;

		private Camera cam;
		bool touchMoved_;
		bool touchEnded_;
		bool multiTouch_;
		int touchId_;

		float xVelocity_;
		float yVelocity_;
		float scaleEffectThreshold_;
		int timeForSelect;
		bool moveTouchPassOneItr_;
		bool isLayerMoving;

		bool isTouchesBeganCalled_;
    
		public bool _touchMoveBegan;

		public float _rubberEffectRatio;
		public bool _rubberEffectRecovering;
		public bool _rubberEffectZooming;

		[HideInInspector]
		public Transform selectedPickableTransform;
	
//		BorderScript borderScript;

		public void Awake ()
		{
			cam = MobileTouchCamera.Instance.main;
			mobileTouchCamera = cam.GetComponent<MobileTouchCamera> ();
			touchInputController = cam.GetComponent<TouchInputController> ();
			mobilePickingController = cam.GetComponent<MobilePickingController> ();

			#region detail callbacks
			touchInputController.OnInputClick += OnInputClick;
			touchInputController.OnDragStart += OnDragStart;
			touchInputController.OnDragStop += OnDragStop;
			touchInputController.OnDragUpdate += OnDragUpdate;
			touchInputController.OnFingerDown += OnFingerDown;
			touchInputController.OnPinchStart += OnPinchStart;
			touchInputController.OnPinchStop += OnPinchStop;
			touchInputController.OnPinchUpdateExtended += new TouchInputController.PinchUpdateExtendedDelegate (OnPinchUpdate);
			#endregion
		}

		public void OnPickableTransformSelected (Transform pickableTransform)
		{
			
		
		}

		public void OnPickableTransformSelectedExtended (PickableSelectedData data)
		{
			Transform pickableTransform = data.SelectedTransform;

		}

		public void OnPickableTransformDeselected (Transform pickableTransform)
		{
			pickableTransform.localScale = Vector3.one;
			selectedPickableTransform = null;

		}

		public void OnPickableTransformMoveStarted (Transform pickableTransform)
		{
		
		}

		public void OnPickableTransformMoved (Transform pickableTransform)
		{

		}

		public void OnPickableTransformMoveEnded (Vector3 startPos, Transform pickableTransform)
		{

		}


		private void OnInputClick (Vector3 clickScreenPosition, bool isDoubleClick, bool isLongTap)
		{

		}

		private void OnPinchUpdate (PinchUpdateData pinchUpdateData)
		{
      
		}

		private void OnPinchStop ()
		{
     
		}

		private void OnPinchStart (Vector3 pinchCenter, float pinchDistance)
		{
     
		}

		private void OnFingerDown (Vector3 screenPosition)
		{
     
		}

		private void OnDragUpdate (Vector3 dragPosStart, Vector3 dragPosCurrent, Vector3 correctionOffset)
		{
     
		}

		private void OnDragStop (Vector3 dragStopPos, Vector3 dragFinalMomentum)
		{
      
		}

		private void OnDragStart (Vector3 pos, bool isLongTap)
		{
      
		}

		private bool GetTransformPositionValid (Transform pickableTransform)
		{
			return true;
		}

		private IEnumerator AnimateScaleForSelection (Transform pickableTransform)
		{
			float timeAtStart = Time.time;
			const float animationDuration = 0.25f;
			while (Time.time < timeAtStart + animationDuration) {
				float progress = (Time.time - timeAtStart) / animationDuration;
				float scaleFactor = 1.0f + Mathf.Sin (progress * Mathf.PI) * 0.2f;
				pickableTransform.localScale = Vector3.one * scaleFactor;
				yield return null;
			}
			pickableTransform.localScale = Vector3.one;
		}

		public void SetInputOnLockedArea ()
		{
			touchInputController.IsInputOnLockedArea = true;
		}

		///////////////////////////////////////////////

		#if UNITY_EDITOR
	[UnityEditor.MenuItem ("Utility/Clear PlayerPrefs")]
		public static void ClearGameData ()
		{
			if (UnityEditor.EditorUtility.DisplayDialog ("Warninig", "Are you sure to clear Game Data ?", "Yes", "No")) {
				PlayerPrefs.DeleteAll ();
				UnityEditor.EditorUtility.DisplayDialog ("Notification", "Game Data Has Been Cleared.", "OK");
			}
		}
		#endif


	}
}
