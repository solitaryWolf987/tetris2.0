﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Group : MonoBehaviour
{
    float lastFall = 0;
    //float RecordedTime1 = 0;
    //float RecordedTime2 = 0;
    //float TimePassed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        // Default position not valid? Then it's game over
        if (!isValidGridPos())
        {
            Debug.Log("GAME OVER");
            GameOverScreen.instance.End();
            Destroy(gameObject);
        }
    }

    void Awake()
    {
        lastFall = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        //RecordedTime1 += 1f;
        //TimePassed = RecordedTime1 - RecordedTime2;
        
        // Left
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1, 0, 0);
            if (isValidGridPos())
            {
                updateGrid();
            }
            else
            {
                transform.position += new Vector3(1, 0, 0);
            }
        }
        // Right
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Modify position
            transform.position += new Vector3(1, 0, 0);

            // See if valid
            if (isValidGridPos())
            {
                // It's valid. Update grid.
                updateGrid();
            }
            else
            {
                // It's not valid. revert.
                transform.position += new Vector3(-1, 0, 0);
            }
        }
        // Rotate
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Rotate(0, 0, -90);

            // See if valid
            if (isValidGridPos())
            {
                // It's valid. Update grid.
                updateGrid();
            }
            else
            {
                // It's not valid. revert.
                transform.Rotate(0, 0, 90);
            }
        }
        // Fall
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Time.timeSinceLevelLoad - lastFall >= 1) {

            //Debug.Log("Time: " + Time.time);
           // Debug.Log("lastFall: " + lastFall);
            //Debug.Log(Time.time - lastFall);
            // Modify position
            transform.position += new Vector3(0, -1, 0);
            //Debug.Log("Falling");
            // See if valid
            if (isValidGridPos())
            {
                // It's valid. Update grid.
                updateGrid();
            }
            else
            {
                // It's not valid. revert.
                transform.position += new Vector3(0, 1, 0);
                // Clear filled horizontal lines
                Playfield.deleteFullRows();
                // Spawn next Group
                FindObjectOfType<Spawner>().spawnNext();
                // Disable script
                enabled = false;
            }
            lastFall = Time.timeSinceLevelLoad;
            //Debug.Log("lastFall 2: " + lastFall);
        }
        //RecordedTime2 += 0.997f;
    }

    bool isValidGridPos()
    {
        foreach (Transform child in transform)
        {
            Vector2 v = Playfield.roundVec2(child.position);
            // Not inside Border?
            if (!Playfield.insideBorder(v)) 
            {
                Debug.Log("not in playfield");
                return false;
            }

            // Block in grid cell (and not part of same group)?
            if (Playfield.grid[(int)v.x, (int)v.y] != null && 
                Playfield.grid[(int)v.x, (int)v.y].parent != transform) 
            {
                return false;
            }         
        }
        return true;
    }

    void updateGrid()
    {
        for (int y = 0; y < Playfield.h; ++y)
        {
            for (int x = 0; x < Playfield.w; ++x)
            {
                if (Playfield.grid[x, y] != null)
                {
                    if (Playfield.grid[x, y].parent == transform)
                    {
                        Playfield.grid[x, y] = null;
                    }
                }
            }
        }
        foreach (Transform child in transform)
        {
            Vector2 v = Playfield.roundVec2(child.position);
            Playfield.grid[(int)v.x, (int)v.y] = child;
        }
    }
}
