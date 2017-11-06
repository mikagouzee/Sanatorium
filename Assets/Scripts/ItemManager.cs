using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour {

    public static ItemManager Instance;

    public List<Item> ItemsFound;

    public Image inventoryDisplayZone;
    public GameObject button;

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
        ItemsFound = new List<Item>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (inventoryDisplayZone.IsActive())
            {
                CloseInventory();
            }
            else
            {
                ShowContent();
            }
        }
	}

    void ShowContent()
    {
        inventoryDisplayZone.gameObject.SetActive(true);

        for (int i = 0; i < ItemsFound.Count; i++)
        {
            var myItem = ItemsFound[i];

            GameObject itemButton = (GameObject)Instantiate(button);
            itemButton.transform.SetParent(inventoryDisplayZone.gameObject.transform);
            Button realButton = itemButton.GetComponent<Button>();

            switch (myItem.sort)
            {
                case "book":
                    realButton.GetComponentInChildren<Text>().text = "Read " + myItem.name;
                    realButton.onClick.AddListener(() => myItem.Use());
                    break;

                case "consumable":
                    realButton.GetComponentInChildren<Text>().text = "Use " + myItem.name;
                    realButton.onClick.AddListener(() => myItem.Use());
                    break;

                default:
                    realButton.GetComponentInChildren<Text>().text = "Equip " + myItem.name;
                    realButton.onClick.AddListener(() => myItem.Equip());
                    break;
            }

        }
    }

    void CloseInventory()
    {
        var previousButtons = inventoryDisplayZone.GetComponentsInChildren<Button>();

        for (int j = 0; j < previousButtons.Length; j++)
        {
            Destroy(previousButtons[j].gameObject);
            //previousButtons[j].gameObject.SetActive(false);
        }

        inventoryDisplayZone.gameObject.SetActive(false);
    }

}
