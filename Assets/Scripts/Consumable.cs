using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Consumable : Item
{
    public bool isBroken;

    public int durability;

    public override void Use()
    {
        return null;
    }
    
}
