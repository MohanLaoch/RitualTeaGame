using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tea : MonoBehaviour
{
    public string nameOfTea;

    public GameObject steam;

    [Header("Tea Sprites")]
    public Sprite[] teaStage;
    public int teaStageNumber = 0;

    [Header("Tea Bag")]
    public string acceptedTeaBag;
    public bool teaBag;

    [Header("Milk")]
    public string acceptedMilk;
    public bool milk;

    [Header("Sugar")]
    public string acceptedSugar;
    public bool sugar;

    private void Awake()
    {
        GetComponent<SpriteRenderer>().sprite = teaStage[teaStageNumber];
    }

    public void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject.tag == acceptedTeaBag)
        {
            teaBag = true;
            Destroy(other.gameObject);   
            
            if (teaBag)
            {
                teaStageNumber++;
                ChangeSprite();
            }
        }

        if (other.gameObject.tag == acceptedMilk)
        {
            milk = true;
            Destroy(other.gameObject);

            if (milk)
            {
                teaStageNumber++;
                ChangeSprite();
            }
        }

        if (other.gameObject.tag == acceptedSugar)
        {
            sugar = true;
            Destroy(other.gameObject);

            if (sugar)
            {
                teaStageNumber++;
                ChangeSprite();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (teaBag && milk && sugar)
        {
            steam.SetActive(true);
            this.gameObject.tag = nameOfTea;
        }
    }

    void ChangeSprite()
    {
        GetComponent<SpriteRenderer>().sprite = teaStage[teaStageNumber];
    }

    /*
     * A string that records the tag for each ingredient type used in the recepie
     * 
     * If the tag is true destroy the other object and set a variable for each ingredient type to true
     * 
     * If they are all true change the tag of this gameobject to the corresponding tag to the customer
     */
}
