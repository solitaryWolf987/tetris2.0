﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Class to check if collision of block with extra time sprite,
 * has occurred.
 */

public class TimeCollider : MonoBehaviour
{
    private float extraTimeCounter = 0;

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Time collide");
        TimerScript.instance.AddTime(5f);
        Destroy(this.gameObject, 1.0f);
        ExtraTime.instance.destroyTime();
        achievements();
    }

    //Calls achievement class and checks if achievement should be given.
    private void achievements()
    {
        Achievements.instance.ExtraTime();
        extraTimeCounter++;
        if (extraTimeCounter == 10)
        {
            Achievements.instance.TenExtraTime();
        }
    }
}
