using UnityEngine;
using System.Collections;
using BehaviorDesigner.Runtime.Tasks;
using LuaFramework;

public class StartUpCommand : ControllerCommand {

    public override void Execute(IMessage message) {
        Debug.Log("StartUpCommand1");
        if (!Util.CheckEnvironment()) return;

        Debug.Log("StartUpCommand2");
        //-----------------初始化管理器-----------------------
        AppFacade.Instance.AddManager<LuaManager>(ManagerName.Lua);
        AppFacade.Instance.AddManager<ResourceManager>(ManagerName.Resource);
        AppFacade.Instance.AddManager<SceneManager>(ManagerName.Scene);
        AppFacade.Instance.AddManager<NetworkManager>(ManagerName.Network);
		AppFacade.Instance.AddManager<GameManager>(ManagerName.Game);
    }
}