using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    public string characterName;
    public bool isAlive;

    public Character()
    {

    }

    public Character(string name, bool life)
    {
        characterName = name;
        isAlive = life;
    }

  
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
