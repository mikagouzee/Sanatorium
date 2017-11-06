using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour {

    public static MonsterController Instance;
    public PlayerController thePlayer;
    public float moveSpeed;

    public bool playerKnowsSpell;

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
        thePlayer = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (playerKnowsSpell)
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                Debug.Log("By the power of the ancients...");
                QuestList.questList[15].EndQuest();
                //PlayerController.Instance.gameObject.SetActive(false);
                PlayerController.Instance.enabled = false;
                gameObject.SetActive(false);

                GameStateManager.Instance.winScreen.gameObject.SetActive(true);
            }
        }
    }

    //TODO 
    void MoveTowardsVictim()
    {
        Character target = GetCharacterPositions();
        //move to it
        gameObject.transform.position =
            Vector3.MoveTowards(gameObject.transform.position, target.transform.position, moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "Player")
        {
            //TODO
            other.gameObject.GetComponent<PlayerController>().enabled = false;
            GameStateManager.Instance.gameOver = true;
        }
    }

    Character GetCharacterPositions()
    {
        Character victim = new Character();
        var distance = 999f;

        for (int i = 0; i < CharacterList.characterList.Count; i++)
        {
            //dirty hack to avoid eating the same character over and over
            //Todo : improve
            if (!CharacterList.characterList[i].isAlive)
                continue;

            var characPosition = CharacterList.characterList[i].gameObject.transform.position;

            if(Vector3.Distance(characPosition, gameObject.transform.position) < distance)
            {
                distance = Vector3.Distance(characPosition, gameObject.transform.position);
                victim = CharacterList.characterList[i];
            }
        }

        return victim;
    }

}
