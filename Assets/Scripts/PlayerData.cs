using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerData {

    public Dictionary<string, int> Stats;

    public PlayerData()
    {
        Stats = new Dictionary<string, int>();

        Stats.Add("strength", 50);
        Stats.Add("constitution", 40);
        Stats.Add("power", 60);
        Stats.Add("dexterity", 80);
        Stats.Add("appearance", 60);
        Stats.Add("size", 50);
        Stats.Add("intelligence", 50);
        Stats.Add("education", 70);
        Stats.Add("psychology", 95);
        Stats.Add("hypnosis", 75);
        Stats.Add("sanity", 80);

        //for debug purposes
        Stats.Add("autofail", 00);



    }

}
