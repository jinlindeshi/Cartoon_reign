using System.Collections.Generic;
using LuaInterface;
using UnityEngine;
/***
 *  接收动画事件，并转发给Lua
 */
public class AnimationEvent : MonoBehaviour
{

    private Dictionary<string, LuaFunction> _callBackDic = new Dictionary<string, LuaFunction>();
    
    public void SetListenerByMsg(string key, LuaFunction callBack)
    {
        _callBackDic[key] = callBack;
    }
    
    void AniEvent(string msg)
    {
        // Debug.Log("AniEvent - hehe " + gameObject.name); 
        if (_callBackDic[msg] != null)
        {
            _callBackDic[msg].Call(msg);
        }
    }
}