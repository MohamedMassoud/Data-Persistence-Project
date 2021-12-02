using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class DataSessionManager : MonoBehaviour
{
    public static PlayerData topPlayerData = new PlayerData();
    public Text bestScoreText;
    private static bool dataLoaded = false;
    private void Awake()
    {
        LoadData();
    }

    private void Start()
    {
        if (dataLoaded)
        {
            bestScoreText.text = $"Best Score : {topPlayerData.topPlayerName} : {topPlayerData.topPlayerScore}";
        }
    }
    public class PlayerData
    {
        public string topPlayerName;
        public int topPlayerScore;
    }

    // Start is called before the first frame update
    public static void SaveData(string playerName, int playerScore)
    {
        topPlayerData.topPlayerName = playerName;
        topPlayerData.topPlayerScore = playerScore;
        string json = JsonUtility.ToJson(topPlayerData);
        File.WriteAllText(Application.persistentDataPath + "/scoreBoard.json", json);
    }

    public static void LoadData()
    {
        string saveDataFilePath = Application.persistentDataPath + "/scoreBoard.json";
        if (File.Exists(saveDataFilePath))
        {

            string json = File.ReadAllText(saveDataFilePath);
            topPlayerData = JsonUtility.FromJson<PlayerData>(json);
            dataLoaded = true;
        }        
    }

}
