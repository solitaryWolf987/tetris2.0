using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoringSystem : MonoBehaviour
{
    public static ScoringSystem instance;

    public Text scoreText;

    float pointsPerSecond = 1;
    float currentScore = 0;
    float lastUpdate = 0;

    private void Awake() 
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + currentScore.ToString();

        
            
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastUpdate >= 1f)
        {
            ScorePerSecond();
            lastUpdate = Time.time;
        }
    }

    public void IncreaseScore(float amount)
    {
        currentScore += amount;
        Debug.Log(currentScore);
        scoreText.text = "Score: " + currentScore.ToString();
    }

    private void ScorePerSecond()
    {
        currentScore += pointsPerSecond;
        scoreText.text = "Score: " + currentScore.ToString();
    }

    
}
