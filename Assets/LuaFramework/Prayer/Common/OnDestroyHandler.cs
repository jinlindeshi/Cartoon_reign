using UnityEngine;
using LuaInterface;

namespace Prayer
{
    public class OnDestroyHandler : MonoBehaviour
    {
        
        public LuaFunction checkCall;
        void OnDestroy()
        {
            checkCall.Call();
        }
    }
}