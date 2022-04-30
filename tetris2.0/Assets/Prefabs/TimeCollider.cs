using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Time collide");
        TimerScript.instance.AddTime(5f);
        Destroy(this.gameObject, 1.0f);
        ExtraTime.instance.destroyTime();

    }
}
