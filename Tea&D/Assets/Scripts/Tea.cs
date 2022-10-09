using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tea : MonoBehaviour
{
    public Animator animator;
    private bool teaBag = false;
    private bool milk = false;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "TeaBag")
        {
            Destroy(other.gameObject);
            teaBag = true;
        }

        if (other.gameObject.tag == "Milk")
        {
            Destroy(other.gameObject);
            milk = true;
        }
    }

    private void Update()
    {
        if (teaBag && milk)
        {
            animator.SetBool("TeaMade", true);
        }
    }

    
}
