using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTea : MonoBehaviour
{
    public COINSspawn Coin;
    public CustomerNumber ID;
    public Move move;
    public GameObject dialogue;
    public List<string> characterText = new List<string>();
    public SpriteRenderer character;

    // Start is called before the first frame update
    void Awake()
    {
        Coin = GameObject.Find("COINSspawner").GetComponent<COINSspawn>();
        ID = GetComponent<CustomerNumber>();
        move = GetComponent<Move>();
    }
    

    // Update is called once per frame
    void OnTriggerStay2D(Collider2D other)
    {
        if (ID.CustomerID == 1)
        {
            if (other.gameObject.tag == "DwarfTea")
            {
                Destroy(other.gameObject);
                Coin.Increase += Random.Range(2, 6);
                move.canLeave = true;
                HadMyTea();
            }
        }

        if (ID.CustomerID == 2)
        {
            if (other.gameObject.tag == "DragonTea")
            {
                Destroy(other.gameObject);
                Coin.Increase += Random.Range(2, 6);
                move.canLeave = true;
                HadMyTea();
            }
        }

        if (ID.CustomerID == 3)
        {
            if (other.gameObject.tag == "AdamTea")
            {
                Destroy(other.gameObject);
                Coin.Increase += Random.Range(2, 6);
                move.canLeave = true;
                HadMyTea();
            }
        }
    }

    void HadMyTea()
    {
        character.flipX = true;
        dialogue = GameObject.FindWithTag("Text");
        dialogue.GetComponent<Dialogue>().StartDialogue(characterText);
    }
    
}
