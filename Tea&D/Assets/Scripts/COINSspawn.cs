using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COINSspawn : MonoBehaviour
{
    public GameObject Spawn;
    public float SpawnTime;
    public float SpawnDelay;
    public int Increase = 0;
    public int Same = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (Increase > Same)
        {
            InvokeRepeating("SpawnObject", SpawnTime, SpawnDelay);
        }
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void SpawnObject()
    {
        Instantiate(Spawn, transform.position, transform.rotation);
        Same += 1;
    }
}
