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
        starDestroy();

    }

    public static void starDestroy()
    {
        
        
        ExtraPoints.instance.destroyStar();

        /*
        GameObject gameObject = new GameObject("ExtraPoints");
        extraPoints = gameObject.AddComponent<ExtraPoints>();
        extraPoints.destroyStar();
        */
    }
}
