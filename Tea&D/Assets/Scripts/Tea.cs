using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tea : MonoBehaviour
{
    public string nameOfTea;

    [Header("Tea Bag")]
    public string acceptedTeaBag;
    public bool teaBag;

    [Header("Milk")]
    public string acceptedMilk;
    public bool milk;

    [Header("Sugar")]
    public string acceptedSugar;
    public bool sugar;


    public void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject.tag == acceptedTeaBag)
        {
            teaBag = true;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == acceptedMilk)
        {
            milk = true;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == acceptedSugar)
        {
            sugar = true;
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (teaBag && milk && sugar)
        {
            this.gameObject.tag = nameOfTea;
        }
    }

    /*
     * A string that records the tag for each ingredient type used in the recepie
     * 
     * If the tag is true destroy the other object and set a variable for each ingredient type to true
     * 
     * If they are all true change the tag of this gameobject to the corresponding tag to the customer
     */
}
