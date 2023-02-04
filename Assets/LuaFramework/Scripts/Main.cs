﻿using UnityEngine;

namespace LuaFramework {

    /// <summary>
    /// </summary>
    public class Main : MonoBehaviour {

        private void Start()
        {
            print("Game Start " + Time.realtimeSinceStartup);
            AppFacade.Instance.StartUp();   //启动游戏
        }
    }
}