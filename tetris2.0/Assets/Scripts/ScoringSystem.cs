using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    private float currentScore;
    public Text scoreText;
    public float pointsPerSecond = 10;


    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //score += pointsPerSecond * Time.deltaTime;
    }

    public void IncreaseScore(float amount)
    {
        currentScore += amount;
        HandleScore();
    }

    private void HandleScore()
    {
        scoreText.text = "Score: " + currentScore;
    }

    
}
