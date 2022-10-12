using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COINSspawn : MonoBehaviour
{
    public GameObject Spawn;
    public Vector2 Spawnpoint;
    public int Increase = 0;
    public int Same = 0;


    // Update is called once per frame
    void Update()
    {
        if (Increase > Same)
        {
         GetCOIN();
        }

    }

    void GetCOIN()
    {
        Instantiate(Spawn, Spawnpoint, transform.rotation);
        Same += 1;
    }

}
