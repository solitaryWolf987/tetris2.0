using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsCollider : MonoBehaviour
{


    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Star collide");
        ScoringSystem.instance.IncreaseScore(10);
        Destroy(this.gameObject, 1.0f);
        //ExtraPoints.instance.destroyStar();
    }

    private void achievements()
    {
        Achievements.instance.ExtraPoints();
        Achievements.instance.TenExtraTime();
    }
}
