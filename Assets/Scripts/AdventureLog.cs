using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureLog : MonoBehaviour {

    public static AdventureLog Instance;

    public Image BookDisplay;
    public Text bookText;

    public List<string> personMet;

    private void Awake()
    {
        if(Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
        personMet = new List<string>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowBook(Book book)
    {
        bookText.text = book.bookContent;
        BookDisplay.gameObject.SetActive(true);
    }

    public void CloseBook()
    {
        bookText.text = "";
        BookDisplay.gameObject.SetActive(false);
    }

}
