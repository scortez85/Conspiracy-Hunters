using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetMan : MonoBehaviour {

    public GameObject[] players;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        players = GameObject.FindGameObjectsWithTag("Player");

        if (players.Length>1)
        for (int k=0;k<players.Length;k++)
        {
           // players[k].GetComponent<PlayerVar>().changeName();  
        }
		
	}

    void OnGUI()
    {
        for (int k = 0; k < players.Length; k++)
            GUI.Label(new Rect(12, 64 + (k * 32), 128, 32), players[k].name);
    }
}
