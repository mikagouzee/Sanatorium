using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public static DialogueManager Instance;

    public GameObject dialogueBox;
    public Text dialogueText;
    public bool dialogueIsActive;

    public string[] dialogueLines;

    public int currentLine;

    private void Awake()
    {
        dialogueIsActive = false;
        currentLine = 0;

        if(Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if(Instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (dialogueLines.Length == 0)
            dialogueIsActive = false;

        if (dialogueIsActive)
        {
            dialogueBox.SetActive(true);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                currentLine++;
            }

            dialogueText.text = dialogueLines[currentLine];

            if (currentLine >= dialogueLines.Length)
            {
                dialogueText.text = "";
                dialogueBox.SetActive(false);
                currentLine = 0;
            }
        }
	}

    public void ShowDialogue(string[] dialogue)
    {
        dialogueIsActive = true;
        dialogueLines = dialogue;
    }

}
