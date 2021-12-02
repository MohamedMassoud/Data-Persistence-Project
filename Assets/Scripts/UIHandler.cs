using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    public TMP_InputField playerNameInputField;

    public void StartGame()
    {
        string playerName = playerNameInputField.text;
        if (playerName != "")
        {
            SceneDataManager.sceneDataManagerSingleton.playerName = playerName;
            SceneManager.LoadScene(1);
        }
    }
}
