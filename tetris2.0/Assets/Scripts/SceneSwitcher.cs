using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public float autoLoadNextLevelAfter;

    
    /**
     void Start() {
        if (autoLoadNextLevelAfter <= 0)
        {
            Debug.Log("Level auto load disabled, use a positive value.");
        }
        else {
            invoke("LoadNextLevel", autoLoadNextLevelAfter);
        }
    }
    */


    public void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    //specific level to load; named on the button UI
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    //quit application
    public void QuitRequest()
    {
        Debug.Log("Quit Requested");
        //SceneManager.Quit ();
    }
}