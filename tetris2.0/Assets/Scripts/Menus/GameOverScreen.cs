using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/**
 * Class to show the game over screen when the function End() is called.
 */

public class GameOverScreen : MonoBehaviour
{
    public static GameOverScreen instance;
    public static bool GameOver = false;


    public GameObject GameOverUI;
    public Text scoreText;
    private float endScore;

    private void Awake()
    {
        instance = this;
    }


    public void End()
    {
        GameOverUI.SetActive(true);
        Time.timeScale = 0f;
        GameOver = true;
        showEndScore();
        Achievements.instance.EndGameFirstTime();
    }


    //Shows end score
    //Sets highscore if it is beaten
    public void showEndScore()
    {
        endScore = ScoringSystem.instance.getCurrentScore();
        scoreText.text = "Score: " + endScore.ToString();
        float highScore = PlayerPrefs.GetFloat("highScore");
        if (endScore > highScore)
        {
            PlayerPrefs.SetFloat("highScore", endScore);
            PlayerPrefs.Save();
        }

    }
    
}
