using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public List<string> lines = new List<string>();
    public float textSpeed;
    public bool isSpeaking = false;
    public GameObject[] characterPrefabs;
    public Transform spawnLocation;
    public CharacterDialogue characterDialogue;
    public bool isActive = false;
    
    private int index;

    public AudioClip[] SpeakingNoises = new AudioClip[0];
    public AudioSource audioSource;
    public AudioListener audioListener;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A) && isActive == false)
        {
            Instantiate(characterPrefabs[Random.Range(0, characterPrefabs.Length)], spawnLocation.position,
                spawnLocation.rotation);
            textComponent.text = string.Empty;
            isActive = true;
            FindObjectOfType<AudioManager>().Play("Text1");
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            characterDialogue = gameObject.GetComponent<CharacterDialogue>();
            if (textComponent.text == lines[index])
            {
                NextLine();
                
            }

            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
                isActive = false;
            }
        }

        if (isSpeaking == true)
        {
            PlayRandom();
        }
        
    }

    public void StartDialogue(List<String> charText)
    {
        
        textComponent.text = string.Empty;
        lines = charText;
        gameObject.SetActive(true);
        index = 0;
        StopAllCoroutines();
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Count - 1)
        {
            FindObjectOfType<AudioManager>().Play("Text1");
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }

        else
        {
            isSpeaking = false;
        }
    }

    void PlayRandom()
    {
        audioSource.clip = SpeakingNoises[Random.Range(0, SpeakingNoises.Length)];
        audioSource.Play();
    }
}
