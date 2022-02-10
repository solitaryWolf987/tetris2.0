using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    public float speed = 1.5f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) 
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * 4.0f * Time.deltaTime;
        }
    }
}
