using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestController : MonoBehaviour {

    public int questNumber;
    public Quest thisQuest;

	// Use this for initialization
	void Start () {
        thisQuest = QuestList.questList[questNumber];
        Debug.Log(thisQuest.name);
	}
	
	// Update is called once per frame
	void Update () {

        if (thisQuest.hasStarted && !(thisQuest.wasCompleted || thisQuest.hasFailed))
        {
            StartCoroutine("CheckQuestState");
        }


	}

    //will this work? get more info about IEnumerator
    IEnumerator CheckQuestState()
    {
        //ITEM QUEST ?
        if (thisQuest.isItemQuest)
        {
            //todo : implement character inventory
            int check = 0;
            foreach (var item in thisQuest.targetItems)
            {
                check = ItemManager.Instance.ItemsFound.Contains(item) ?
                    check++ :
                    check;
            }

            if (check == thisQuest.targetItems.Count)
                thisQuest.EndQuest();
        }

        //PERSON QUEST ?
        if (thisQuest.isPersonQuest)
        {
            if (AdventureLog.Instance.personMet.Contains(thisQuest.targetPerson))
                thisQuest.EndQuest();
        }


        //STEP QUEST ?
        if (thisQuest.hasSteps)
        {
            int check = 0;
            foreach (int index in thisQuest.subQuests)
            {
                if (QuestList.questList[index].wasCompleted)
                    check++;
            }

            if (check == QuestList.questList.Count)
                thisQuest.EndQuest();
        }

        yield return new WaitForSeconds(1f);
    }

}
