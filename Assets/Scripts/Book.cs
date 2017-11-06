using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : Item
{
    public string bookContent;
    public Sprite bookDisplay;

    public bool isBeingRead;


    public Book(string myname, string desc)
    {
        name = myname;
        description = desc;
        sort = "book";
    }

    public override void Use()
    {
        if (!isBeingRead)
            AdventureLog.Instance.ShowBook(this);
        else
            AdventureLog.Instance.CloseBook();
    }
}