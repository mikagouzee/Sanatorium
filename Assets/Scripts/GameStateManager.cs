using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStateManager : MonoBehaviour {

    public static GameStateManager Instance;

    public bool IsSceneBeingLoaded;
    public PlayerData localCopyOfPlayerData;

    public bool gameOver;
    public float gameResetTimer = 500f;
    public Image gameOverScreen;

    public Image winScreen;

    //SINGLETON PATTERN
    private void Awake()
    {
        gameOver = false;

        if(Instance = null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        while (gameOver)
        {
            gameOverScreen.gameObject.SetActive(true);
            //playerController.Instance.enabled = false;

            gameResetTimer -= Time.deltaTime;

            if(gameResetTimer <= 0.0f)
            {
                gameOver = false;
                SceneManager.LoadScene(0);
            }

        }
	}

    public void SaveData()
    {
        if (!Directory.Exists("Saves"))
            Directory.CreateDirectory("Saves");

        BinaryFormatter formatter = new BinaryFormatter();
        FileStream saveFile = File.Create("Saves/save.binary");

        localCopyOfPlayerData = PlayerSheet.Instance.playerData;
        formatter.Serialize(saveFile, localCopyOfPlayerData);
        saveFile.Close();
    }

    public void LoadData()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream saveFile = File.Open("Saves/save.binary", FileMode.Open);

        localCopyOfPlayerData = (PlayerData)formatter.Deserialize(saveFile);
        saveFile.Close();

    }

}
