using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextCustomer : MonoBehaviour
{
    public GameObject Next;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Door")
        {
            Next.SetActive(true);
        }
    }
}
