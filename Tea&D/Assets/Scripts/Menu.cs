using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject thisMenu;
    public GameObject[] otherMenus;

    public void menuSwitch()
    {
        thisMenu.SetActive(true);
        
        foreach (GameObject i in otherMenus)
        {
            i.SetActive(false);
        }
    }
}
