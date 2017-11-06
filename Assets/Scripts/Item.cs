using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item
{

    public string name;
    public string sort; //book, weapon, consumable, tool

    public string description;
    public string effectDescription;

    public bool isEquipped;

    public Sprite itemImage;
    public Color myColor;

    //public EquipmentManager equipMan;
    public GameObject gObject;


    abstract public void Use();

    virtual public void Equip() { }

    //virtual public void Equip()
    //{
    //    if (isEquipped)
    //    {
    //        QuestManager.Instance.ShowQuestText("You already equipped that item");
    //        return;
    //    }
    //    else if (EquipmentManager.Instance.isEquippedA)
    //    {
    //        EquipmentManager.Instance.itemInA = this;
    //        EquipmentManager.Instance.imageA.image.sprite = itemImage;
    //        EquipmentManager.Instance.imageA.image.color = myColor;
    //        EquipmentManager.Instance.isEquippedA = true;

    //        isEquipped = true;
    //    }
    //    else if (!EquipmentManager.Instance.isEquippedB)
    //    {
    //        EquipmentManager.Instance.itemInB = this;
    //        EquipmentManager.Instance.imageB.image.sprite = itemImage;
    //        EquipmentManager.Instance.imageB.image.color = myColor;
    //        EquipmentManager.Instance.isEquippedB = true;

    //        isEquipped = true;
    //    }
    //    else
    //    {
    //        QuestManager.Instance.ShowQuestText("You already equipped the maximum items");
    //    }
    //}

    //virtual public void Unequip()
    //{
    //    GameObject buttonClicked = EventSystem.current.currentSelectedGameObject;

    //    if (buttonClicked == EquipmentManager.Instance.imageA.gameObject)
    //    {
    //        isEquipped = false;
    //        EquipmentManager.Instance.isEquippedA = false;
    //        EquipmentManager.Instance.itemInA = null;
    //        EquipmentManager.Instance.imageA.image.sprite = null;
    //        Color myColor = new Color();
    //        ColorUtility.TryParseHtmlString("#FFFFFF01", out myColor);
    //        EquipmentManager.Instance.imageA.image.color = myColor;
    //    }
    //    else if (buttonClicked == EquipmentManager.Instance.imageB.gameObject)
    //    {
    //        isEquipped = false;
    //        EquipmentManager.Instance.isEquippedB = false;
    //        EquipmentManager.Instance.itemInB = null;
    //        EquipmentManager.Instance.imageB.image.sprite = null;
    //        Color myColor = new Color();
    //        ColorUtility.TryParseHtmlString("#FFFFFF01", out myColor);
    //        EquipmentManager.Instance.imageB.image.color = myColor;
    //    }
    //}

    virtual public string Inspect()
    {
        return description;
    }

}