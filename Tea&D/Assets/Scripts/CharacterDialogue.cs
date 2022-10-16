using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDialogue : MonoBehaviour
{

    public GameObject dialogue;
    public List<string> characterText = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        dialogue = GameObject.FindWithTag("Text");
        dialogue.GetComponent<Dialogue>().StartDialogue(characterText);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
