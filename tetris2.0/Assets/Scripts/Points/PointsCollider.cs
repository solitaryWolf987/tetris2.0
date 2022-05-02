using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Class to check if collision of block with extra points sprite,
 * has occurred.
 */

public class PointsCollider : MonoBehaviour
{
    private float extraPointsCounter = 0;

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Star collide");
        ScoringSystem.instance.IncreaseScore(10);
        Destroy(this.gameObject, 1.0f);
        ExtraPoints.instance.destroyStar();
        achievements();
    }

    //Calls achievement class and checks if achievement should be given.
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
