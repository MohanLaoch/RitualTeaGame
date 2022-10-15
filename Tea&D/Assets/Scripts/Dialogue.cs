using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public bool isSpeaking = false;
    public GameObject[] characterPrefabs;
    public Transform spawnLocation;

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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(characterPrefabs[Random.Range(0, characterPrefabs.Length)], spawnLocation.position,
                spawnLocation.rotation);
        }

        if(Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }

            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }

        if (isSpeaking == true)
        {
            PlayRandom();
        }
        
    }

    void StartDialogue()
    {
        gameObject.SetActive(true);
        index = 0;
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
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }

        else
        {
            isSpeaking = false;
            gameObject.SetActive(false);
        }
    }

    void PlayRandom()
    {
        audioSource.clip = SpeakingNoises[Random.Range(0, SpeakingNoises.Length)];
        audioSource.Play();
    }
}
