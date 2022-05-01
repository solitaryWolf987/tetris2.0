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
    private int extraPointsCounter = 0;
    private bool extraTime = false;
    private bool tenExtraTime = false;
    private int extraTimeCounter = 0;


    void Awake()
    {
        instance = this;
    }

    public void HundredPoints()
    {
        if (!hundredPoints)
        {
            Debug.Log("Achievement: First 100 points!");
            hundredPoints = true;
        }
    }

    public void FiveHundredPoints()
    {
        if (!fiveHundredPoints)
        {
            Debug.Log("Achievement: 500 points obtained!");
            fiveHundredPoints = true;
        }
    }

    public void ExtraPoints()
    {
        if (!extraPoints)
        {
            Debug.Log("Achievement: First extra points!");
            extraPoints = true;
        }
        extraPointsCounter++;
    }

    public void TenExtraPoints()
    {
        if (!tenExtraPoints)
        {
            if (extraPointsCounter == 10)
            {
                Debug.Log("Achievement: Ten extra points tokens caught!");
                tenExtraPoints = true;
            }
        }
        
    }

    public void ExtraTime()
    {
        if (!extraTime)
        {
            Debug.Log("Achievement: First extra time!");
            extraTime = true;
        }
        extraTimeCounter++;
    }

    public void TenExtraTime()
    {
        if (!tenExtraTime)
        {
            if (extraTimeCounter == 10)
            {
                Debug.Log("Achievement: Ten extra time tokens caught!");
                tenExtraTime = true;
            }
        }
    }

}
