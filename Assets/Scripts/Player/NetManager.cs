using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class NetManager : NetworkBehaviour {
    [SyncVar]
    public string playerName;
    [SyncVar]
    public int playerId;



    [RPC]
    public void RpcSyncPlayerId(int num)
    {
        playerId = num;
    }
    [RPC]
    public void RpcSyncName(string name)
    {
        playerName = "empty";
        playerName = name;
    }
    [Command]
    public void CmdName(string name)
    {
        playerName = name;
    }
    [Command]
    public void CmdId(int Id)
    {
        playerId = Id;
    }
    public void changeName(string name)
    {
        if (!isLocalPlayer)
            CmdName(name);
        RpcSyncName(name);
    }
    public void changeId(int ID)
    {
        if (!isLocalPlayer)
            CmdId(ID);
        RpcSyncPlayerId(ID);
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
