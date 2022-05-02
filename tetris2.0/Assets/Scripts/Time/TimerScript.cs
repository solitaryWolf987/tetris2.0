using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/**
 * Class to track the time left in the game.
 * Displays the time left on the screen as well.
 */

public class TimerScript : MonoBehaviour
{
    public static TimerScript instance;
    public float timeRemaining = 120;
    public bool timerIsRunning = false;
    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        DisplayTime(timeRemaining);
    }

    void Awake()
    {
        instance = this;
        timeRemaining = 120;
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                DisplayTime(timeRemaining);
                EndGame();
                timerIsRunning = false;
            }
        }
    }

    //Displays time in minutes and seconds.
    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("Timer: {0:00}:{1:00}", minutes, seconds);
    }

    //Adds extra time to the imeRemaining variable when called.
    public void AddTime(float timeAmount)
    {
        timeRemaining += timeAmount;
        DisplayTime(timeRemaining);
    }

    //Makes the game over screen show when called.
    public void EndGame()
    {
        GameOverScreen.instance.End();
        Debug.Log("Game over");
    }
}
