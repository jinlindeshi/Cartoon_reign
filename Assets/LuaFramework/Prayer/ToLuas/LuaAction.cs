using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks
{
    //执行Lua回调的Action
    public class LuaAction:Action
    {
        public SharedFloat paramFloat;
        public SharedBool paramBool;
        private BehaviorToLua btl;

        private TaskStatus _updateStatus;

        public void SetUpdateStatus(TaskStatus status)
        {
            _updateStatus = status;
        }
        public TaskStatus GetUpdateStatus()
        {
            return　_updateStatus;
        }


        private void InvokeFun(string funName, bool paused = false)
        {
            btl.InvokeFun(FriendlyName, this, funName, paramFloat.Value, paramBool.Value, paused);
        }

        public override void OnAwake()
        {
            btl = this.gameObject.GetComponent<BehaviorToLua>();
            InvokeFun("OnAwake");
        }

        public override void OnStart()
        {
            base.OnStart();
//            _updateStatus = TaskStatus.Success;
            InvokeFun("OnStart");
        }

        public override TaskStatus OnUpdate()
        {
//            Debug.Log("LuaAction - OnUpdate");
            InvokeFun("OnUpdate");
            return _updateStatus;
        }

         public override void OnPause(bool paused)
        {
            InvokeFun("OnPause", paused);
        }
        
        public override void OnEnd()
        {
            InvokeFun("OnEnd");
        }

        public override void OnReset()
        {
//            Debug.Log("LuaAction - OnReset");
            InvokeFun("OnReset");
        }

        public override void OnBehaviorComplete()
        {
            InvokeFun("OnBehaviorComplete");
        }

        public override void OnBehaviorRestart()
        {
            InvokeFun("OnBehaviorRestart");
        }
    }
}