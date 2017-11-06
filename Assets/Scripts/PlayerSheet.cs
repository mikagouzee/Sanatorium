using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSheet : MonoBehaviour {

    public static PlayerSheet Instance;

    public PlayerData playerData;

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

    // Use this for initialization
    void Start () {
        if (GameStateManager.Instance.IsSceneBeingLoaded)
        {
            playerData = GameStateManager.Instance.localCopyOfPlayerData;
            GameStateManager.Instance.IsSceneBeingLoaded = false;
        }
        else
        {
            playerData = new PlayerData();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool RollAgainst(string statName)
    {
        System.Random r = new System.Random();

        int diceRoll = r.Next(1, 100);

        if (diceRoll <= playerData.Stats[statName])
        {
            return true;
        }
        else
        {
            QuestManager.Instance.ShowQuestText(string.Format("Your roll of {0} was aa failure : {1} on {2}", statName, diceRoll, playerData.Stats[statName]));
            return false;
        }
    }

}
