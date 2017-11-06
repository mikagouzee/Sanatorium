using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour {

    public static QuestManager Instance;

    #region fields
    public bool questLogIsActive;
    public bool questBoxIsActive;

    //player questLog
    public GameObject questLog;
    public Text questLogText;

    //quest descriptive
    public GameObject questBox;
    public Text questText;
#endregion


    private void Awake()
    {
        if(Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if(Instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initializationC:\Users\mgouzee\Documents\Sanatorium_Alpha_post_prototype\Assets\Scripts\QuestManager.cs
    void Start () {
        questLogIsActive = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowQuestText(string qText)
    {
        questBox.SetActive(true);
        questText.text = qText;
        questBoxIsActive = true;
    }

    public void ShowCurrentQuests()
    {
        questLogIsActive = true;
        questLogText.text = "Here's what I should check : \n";

        foreach (var aQuest in QuestList.questList.Values)
        {
            if (aQuest.hasStarted && !aQuest.hasFailed && !aQuest.wasCompleted)
                questLogText.text += aQuest.name + ".\n";
        }

    }

}
