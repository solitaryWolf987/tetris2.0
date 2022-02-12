using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    public float speed = 1.5f;

    // Update is called once per frame
    void Update()
    {
        //move left
        if (Input.GetKey(KeyCode.A)) 
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        //move right
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        //move up
        //Will be removed when the other parts of the game are created
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        //move down
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * 5.0f * Time.deltaTime;
        }
        //rotate by 90 degrees
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Rotate(0, 0, 90);
        }

    }
}
