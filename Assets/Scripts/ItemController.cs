using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{

    public Item myItem;
    public string myName;

    // Use this for initialization
    void Start()
    {
        myItem = ItemList.existingStuff[this.gameObject.name.ToLower()];
        myName = gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            QuestManager qMan = FindObjectOfType<QuestManager>();
            var anItem = ItemList.existingStuff[myName.ToLower()];
            ////qMan.ShowQuestText(myItem.GetType().ToString() + " " + gameObject.name );

            //if (myItem.GetType() == typeof(Consumable))
            //    qMan.ShowQuestText("Consumable");
            //else
            //    qMan.ShowQuestText(myItem.GetType().ToString());
            qMan.ShowQuestText(myName + " " + anItem.ToString());
        }
    }

    public void Use()
    {
        myItem.Use();
    }

    public void Equip()
    {
        //myItem.Equip();
    }
}
