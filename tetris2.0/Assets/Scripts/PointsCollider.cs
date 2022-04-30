﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsCollider : MonoBehaviour
{
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Star collide");
        ScoringSystem.instance.IncreaseScore(50);
        Destroy(collision.gameObject, 1.0f);
        starDestroy();

    }

    public static void starDestroy()
    {
        
        ExtraPoints extraPoints = new ExtraPoints();
        extraPoints.destroyStar();

        /*
        GameObject gameObject = new GameObject("ExtraPoints");
        extraPoints = gameObject.AddComponent<ExtraPoints>();
        extraPoints.destroyStar();
        */
    }
}
