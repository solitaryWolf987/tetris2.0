using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievements : MonoBehaviour
{
    public static Achievements instance;

    private bool hundredPoints = false;
    private bool fiveHundredPoints = false;
    private bool extraPoints = false;
    private bool tenExtraPoints = false;
    //private int extraPointsCounter = 0;
    private bool extraTime = false;
    private bool tenExtraTime = false;
    //private int extraTimeCounter = 0;
    private bool endGameFirstTime = false;


    void Awake()
    {
        instance = this;
    }

    public void HundredPoints()
    {
        if (!hundredPoints)
        {
            if (ScoringSystem.instance.getCurrentScore() >= 100)
            {
                Debug.Log("Achievement: First 100 points!");
                hundredPoints = true;
            } 
        }
    }

    public void FiveHundredPoints()
    {
        if (!fiveHundredPoints)
        {
            if (ScoringSystem.instance.getCurrentScore() >= 500)
            {
                Debug.Log("Achievement: 500 points obtained!");
                fiveHundredPoints = true;
            }
        }
    }

    public void ExtraPoints()
    {
        if (!extraPoints)
        {
            Debug.Log("Achievement: First extra points!");
            extraPoints = true;
        }
    }

    public void TenExtraPoints()
    {
        if (!tenExtraPoints)
        {
            Debug.Log("Achievement: Ten extra points tokens caught!");
            tenExtraPoints = true;
        }
    }

    public void ExtraTime()
    {
        if (!extraTime)
        {
            Debug.Log("Achievement: First extra time!");
            extraTime = true;
        }
    }

    public void TenExtraTime()
    {
        if (!tenExtraTime)
        {
            Debug.Log("Achievement: Ten extra time tokens caught!");
            tenExtraTime = true;
        }
    }


    public void EndGameFirstTime()
    {
        if (!endGameFirstTime)
        {
            Debug.Log("Achievement: Game Over for the first time!");
            endGameFirstTime = true;
        }
    }

}
