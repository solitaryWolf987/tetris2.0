using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsCollider : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D trigger)
    {
        Debug.Log("Star collide");
        ScoringSystem.instance.IncreaseScore(50);
    }
}
