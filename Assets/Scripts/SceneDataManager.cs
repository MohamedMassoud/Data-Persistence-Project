using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneDataManager : MonoBehaviour
{
    public static SceneDataManager sceneDataManagerSingleton {private set; get; }
    public string playerName;

    private void Awake()
    {
        if(sceneDataManagerSingleton != null)
        {
            Destroy(this.gameObject);
            return;
        }

        sceneDataManagerSingleton = this;
        DontDestroyOnLoad(sceneDataManagerSingleton);
    }
}
