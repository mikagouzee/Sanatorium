using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest {
    public string name;
    public int questNumber;

    public string endText;

    public bool isItemQuest;
    public List<Item> targetItems;

    public bool isPersonQuest;
    //public List<string> targetPersons;
    public string targetPerson;

    //should we do quest before this one?
    public bool isLaterQuest;
    public int[] questsToCompleteBefore;
    
    public bool startOtherQuests;
    public int[] questsToStart;

    public bool hasSteps;
    public int[] subQuests;

    public bool hasStarted;
    public bool hasFailed;
    public bool wasCompleted;

    //currently check for a roll against a stat
    public bool hasCondition;
    public string statToRollAgainst;

    //to work on
    public bool isLoseCondition;

    // Check if dice roll condition is met
    // Start next quests if required
    public void EndQuest()
    {
        Debug.Log("ending quest " + questNumber);

        if (hasSteps)
        {
            foreach (int index in subQuests)
            {
                if (!QuestList.questList[index].wasCompleted)
                    return;
            }
        }

        //if (hasCondition)
        //{
        //    //QuestManager qMan = FindObjectOfType<QuestManager>();

        //    if (PlayerController.Instance.RollAgainst(statToRollAgainst))
        //    {
        //        wasCompleted = true;
        //        QuestManager.Instance.ShowQuestText(endText);
        //    }
        //    else
        //    {
        //        return;
        //    }
        //}

        wasCompleted = true;

        if (questNumber == 23)
        {
            //monsterController.Instance.playerKnowsSpell = true;
        }

        if (startOtherQuests)
        {
            foreach (int index in questsToStart)
            {
                QuestList.questList[index].StartQuest();
            }
        }

        QuestManager.Instance.ShowQuestText(endText);
    }

    public void StartQuest()
    {

        if (hasStarted)
            return;

        if (isLaterQuest)
        {
            int check = 0;
            //check if the quests to do before have been completed
            foreach (int index in questsToCompleteBefore)
            {
                if (QuestList.questList[index].wasCompleted)
                    check++;
            }
            //otherwise, return
            if (check != questsToCompleteBefore.Length)
                return;
        }

        //then we can start
        hasStarted = true;
        Debug.Log("starting quest " + name + " No " + questNumber);
        if (questNumber == 22)
        {
            Debug.Log("Annephis time has come");
            //QuestManager.Instance.annephis.gameObject.SetActive(true);
        }

        QuestManager.Instance.ShowQuestText(name);

        // If it's a step quest, we start the various subquests
        if (hasSteps)
        {
            foreach (int index in subQuests)
            {
                QuestList.questList[index].StartQuest();
            }
        }

    }

    public void FailQuest()
    {
        if (isLoseCondition)
        {
            //GameStateManager.Instance.gameOver = true;
        }
        //QuestList.questList[questNumber].hasFailed = true;
        hasFailed = true;
    }

}
