using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTrigger : MonoBehaviour {

    public GameObject monster;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        // if the monster is already active, no need to calcul further
        if (monster.activeSelf)
            return;


        if (other.gameObject.name == "Player")
        {
            monster.SetActive(true);
            QuestManager.Instance.ShowQuestText("HAAAAAARGH! \n WHAT THE FUCK IS THAT ? \n OMG I'M GONNA DIIIIIIIIIE ! !");
            //WaitForSeconds(1f);
            QuestList.questList[14].EndQuest();
        }
        
    }

}
