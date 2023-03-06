using System.Collections.Generic;
using UnityEngine;
using LuaInterface;

namespace Prayer
{
    public class TouchEvent : MonoBehaviour
    {
	    private const string TOUCH_BEGIN = "TouchEvent_Begin";
	    private const string TOUCH_MOVE = "TouchEvent_Move";
	    private const string TOUCH_END = "TouchEvent_End";

	    private Dictionary<string, List<LuaFunction>> _listenerDic = new Dictionary<string, List<LuaFunction>>();
	    
	    /// 当前是否正在触摸中
	    private bool s_touching = false;
	    /// 记录触摸或点击的位置
	    private Vector2 s_pos = new Vector2();
	    // 记录当前交互位置与上次位置的偏移 用来判断交互状态
	    private Vector2 s_deltaPos = new Vector2();
	    /// 记录移动端当前触摸的fingerId 用来排除多指操作
	    private int s_id = -1;
	    
	    //添加监听
	    public void AddListener(string type, LuaFunction call)
	    {
		    if(_listenerDic.ContainsKey(type) == false)
		    {
			    _listenerDic[type] = new List<LuaFunction>();
		    }
		    _listenerDic[type].Add(call);
	    }
	    
	    //移除监听
	    public void RemoveListener(string type, LuaFunction call)
	    {
		    List<LuaFunction> callList;
		    if (_listenerDic.TryGetValue(type, out callList))
		    {
			    Debug.Log("======删除之前"+ callList.Count);
			    for (int i = 0; i < callList.Count; i++)
			    {
				    if (callList[i] == call)
				    {
					    callList.RemoveAt(i);
					    break;
				    }
			    }
			    Debug.Log("======删除之后"+ _listenerDic[type].Count);
		    }
	    }
	    
	    //派发事件
	    void DispatchEvent(string type)
	    {
		    if (_listenerDic.ContainsKey(type) == false)
		    {
			    return;
		    }
		    for (int i = 0; i < _listenerDic[type].Count; i++)
		    {
			    _listenerDic[type][i].Call(type, s_pos, s_id);
		    }
	    }

	    void Update()
        {
	        //Editor调用
#if UNITY_EDITOR
	        Vector3 p = Input.mousePosition;
            if (s_touching)
            {
                s_deltaPos.Set(p.x - s_pos.x, p.y - s_pos.y);
                if (Input.GetMouseButtonUp(0))
                {
                    s_touching = false;
                    s_pos.Set(p.x, p.y);
                    DispatchEvent(TOUCH_END);

                }
                else if (s_deltaPos.x != 0 || s_deltaPos.y != 0)
                {
                    s_pos.Set(p.x, p.y);
                    DispatchEvent(TOUCH_MOVE);
                }

            }
            else
            {
                if (Input.GetMouseButtonDown(0))
                {
                    s_touching = true;
                    s_pos.Set(p.x, p.y);
                    s_deltaPos.Set(0, 0);
                    DispatchEvent(TOUCH_BEGIN);
                }
            }


            // 移动端调用
#else

			int touchCount = Input.touchCount;
			if (touchCount == 0) {
				// 容错
				if (s_touching) {
					s_touching = false;
					s_deltaPos.Set (0, 0);
					DispatchEvent (TOUCH_END);
				}
				return;
			}

			Touch touch;
			Vector2 p;
			int i;
			if (s_touching) {
				for (i = 0; i < touchCount; i++) {
					touch = Input.GetTouch (i);
					if (touch.fingerId == s_id) {

						p = touch.position;
						s_deltaPos.Set (p.x - s_pos.x, p.y - s_pos.y);

						if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled) {
							s_touching = false;
							s_pos.Set (p.x, p.y);
							DispatchEvent (TOUCH_END);
						} else if (s_deltaPos.x != 0 || s_deltaPos.y != 0) {
							s_pos.Set (p.x, p.y);
							DispatchEvent (TOUCH_MOVE);
						}
						break;
					}
				}


			} else {
				for (i = 0; i < touchCount; i++) {
					touch = Input.GetTouch (i);
					if (touch.phase == TouchPhase.Began) {
						s_touching = true;
						s_id = touch.fingerId;
						p = touch.position;
						s_pos.Set (p.x, p.y);
						s_deltaPos.Set (0, 0);
						DispatchEvent (TOUCH_BEGIN);
						break;
					}
				}
			}
#endif
		}

	}
}