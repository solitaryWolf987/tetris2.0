using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsCollider : MonoBehaviour
{
    private float extraPointsCounter = 0;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Star collide");
        ScoringSystem.instance.IncreaseScore(10);
        Destroy(this.gameObject, 1.0f);
        ExtraPoints.instance.destroyStar();
        achievements();
    }

    private void achievements()
    {
        Achievements.instance.ExtraPoints();
        extraPointsCounter++;
        if (extraPointsCounter == 10)
        {
            Achievements.instance.TenExtraPoints();
        }
    }
}
