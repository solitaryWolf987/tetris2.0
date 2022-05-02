using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/**
 * Class to show the highscore text on the main menu using PlayerPrefs.
 */

public class MainMenu : MonoBehaviour
{

    public Text scoreText;


    void Awake()
    {
        float highScore = PlayerPrefs.GetFloat("highScore");
        scoreText.text = "High Score: " + highScore.ToString();
    }

}
