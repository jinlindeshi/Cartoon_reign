using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LuaFramework {
    public class AppConst {

        public static bool LuaByteMode = false;                       //Lua字节码模式-默认关闭 
		public static bool BundleMode = false;                    //AssetBundle模式 
        public static bool UpdateMode = false;                    //访问更新服务器的更新模式

        public const int GameFrameRate = 60;                        //游戏帧频

		public const string ResPathHead = "Res/";        //资源路径前缀

        public const string AppName = "DemoHanging";               //应用程序名称
        public const string LuaTempDir = "TempLua/";                    //临时目录
        public const string AppPrefix = AppName + "_";              //应用程序前缀
        public const string ExtName = ".unity3d";                   //素材扩展名
        public const string AssetDir = "StreamingAssets";           //素材目录 


        public static string GameServerIP = "10.8.3.214";      //游戏服IP

//        public static string GameServerIP = "127.0.0.1";      //游戏服IP
        public static int GameServerPort = 7878;      //游戏服IP

        public static string UserId = string.Empty;                 //用户ID
        public static int SocketPort = 0;                           //Socket服务器端口
        public static string SocketAddress = string.Empty;          //Socket服务器地址

        public static string FrameworkRoot {
            get {
                return Application.dataPath + "/LuaFramework";
            }
        }
    }
}