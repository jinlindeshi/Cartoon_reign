using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using LuaInterface;

namespace Prayer
{
    public class OperateHandler : MonoBehaviour
    {
        protected Dictionary<string, List<LuaFunction>> funDic = new Dictionary<string, List<LuaFunction>>();

        public void AddCall(string type, LuaFunction call)
        {
            if(funDic.ContainsKey(type) == false)
            {
                funDic[type] = new List<LuaFunction>();
            }
            funDic[type].Add(call);
        }

        public void RemoveCall(string type, LuaFunction call)
        {
//            var removeIndex = -1;
//            for (int i = 0; i < funDic[type].Count; i++)
//            {
//                if (funDic[type][i] == call)
//                {
//                    removeIndex = i;
//                    break;
//                }
//            }
//            Debug.Log("RemoveCall1 " + removeIndex + " ^ " + funDic[type].Count + " ^ " + call);
//            if (removeIndex > 0)
//            {
//                funDic[type].RemoveAt(removeIndex);
//            }
//            Debug.Log("RemoveCall2 " + removeIndex + " ^ " + funDic[type].Count + " ^ " + call);
            ///TODO RemoveCall无法正常移除 暂时按钮只支持唯一事件
            if (funDic[type] != null)
            {
                funDic[type].Clear();
            }
        }

        protected void TakeCall(string type, PointerEventData eventData)
        {
            if (funDic.ContainsKey(type) == false)
            {
                return;
            }
            for (int i = 0; i < funDic[type].Count; i++)
            {
                funDic[type][i].Call(eventData);
            }
        }
    }
}