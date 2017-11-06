using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    public int characterNumber;
    public Character thisCharacter;

	// Use this for initialization
	void Start () {
        thisCharacter = CharacterList.characterList[characterNumber];
        Debug.Log(thisCharacter.name + "is associated to object " + this.gameObject.name);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public Vector2 getPosition()
    {
        return new Vector2(
            gameObject.transform.position.x,
            gameObject.transform.position.y);
    }

}
