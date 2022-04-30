using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
                timerIsRunning = false;
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("Timer: {0:00}:{1:00}", minutes, seconds);
    }

    public void AddTime(float timeAmount)
    {
        Debug.Log("Time before: " + timeRemaining);
        timeRemaining += timeAmount;
        Debug.Log("Time after: " + timeRemaining);
        DisplayTime(timeRemaining);
    }
}
