using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Class that allows the movement between scenes.
 */

public class SceneSwitcher : MonoBehaviour
{
    public static SceneSwitcher instance;

    public float autoLoadNextLevelAfter;


    void Awake()
    {
        instance = this;
    }

    //Loads the next Level in the build menu.
    public void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);

    }

    //Specific level to load; named on the button UI.
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    //Quit application.
    public void QuitRequest()
    {
        Application.Quit();
        Debug.Log("Quit request complete");
    }
}