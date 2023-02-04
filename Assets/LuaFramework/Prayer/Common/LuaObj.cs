using UnityEngine;
using System.Collections;
using LuaInterface;

namespace Prayer
{
    public class LuaObj : MonoBehaviour
    {
        public LuaFunction checkCall;

        private void CallLua(string funName)
        {
            if (checkCall == null)
            {
                return;
            }
            checkCall.Call(funName);
        }
        // Use this for initialization
        void Start()
        {
            CallLua("Start");
        }

        // Update is called once per frame
        void Update()
        {
            CallLua("Update");
        }

        void FixedUpdate()
        {
            CallLua("FixedUpdate");
        }

        void LateUpdate()
        {
            CallLua("LateUpdate");
        }

        void OnDestroy()
        {
            CallLua("OnDestroy");
        }

        private void OnMouseDown()
        {
            CallLua("OnMouseDown");
        }

        private void OnMouseEnter()
        {
            CallLua("OnMouseEnter");
        }

        private void OnMouseDrag()
        {
            CallLua("OnMouseDrag");
        }
        
        private void OnMouseUp()
        {
            CallLua("OnMouseUp");
        }

        private void OnMouseOver()
        {
            CallLua("OnMouseOver");
        }

        private void OnMouseExit()
        {
            CallLua("OnMouseExit");
        }
    }
}
