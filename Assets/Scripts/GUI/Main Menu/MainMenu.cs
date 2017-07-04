using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainMenu : MonoBehaviour {

    public GameObject[] menus;
	
    public void changeMenu (string menu)
    {
        int id = 0;
        for (int k=0;k<menus.Length;k++)
        {
            if (menus[k].name.Equals(menu))
            {
                id = k;
            }
            menus[k].SetActive(false);
        }
        menus[id].SetActive(true);
    }
}
