using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCollider : MonoBehaviour
{
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Time collide");
        TimerScript.instance.AddTime(5f);
        Destroy(this.gameObject, 1.0f);
        ExtraTime.instance.destroyTime();
        //achievements();
    }


    private void achievements()
    {
        Achievements.instance.ExtraTime();
        Achievements.instance.TenExtraTime();
    }
}
