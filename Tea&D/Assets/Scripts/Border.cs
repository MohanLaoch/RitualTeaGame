using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    public bool tableEdge;

    private void OnTriggerStay2D(Collider2D collision)
    {
        Destroy(collision.gameObject);

        if (tableEdge)
        {
            //Play the sound
            return;
        }

    }
}
