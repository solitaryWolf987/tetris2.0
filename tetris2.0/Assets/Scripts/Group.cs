using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Group : MonoBehaviour
{
    float lastFall = 0;
    // Start is called before the first frame update
    void Start()
    {
        // Default position not valid? Then it's game over
        if (!isValidGridPos())
        {
            Debug.Log("GAME OVER");
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Left
        if (Input.GetKeyDown(KeyCode.A))
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
        else if (Input.GetKeyDown(KeyCode.D))
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
        else if (Input.GetKeyDown(KeyCode.W))
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
        else if (Input.GetKeyDown(KeyCode.S) || Time.time - lastFall >= 1) {
            // Modify position
            transform.position += new Vector3(0, -1, 0);
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
            lastFall = Time.time;
        }

    }

    bool isValidGridPos()
    {
        foreach (Transform child in transform)
        {
            Vector2 v = Playfield.roundVec2(child.position);

            // Not inside Border?
            if (!Playfield.insideBorder(v)) 
            {
                return false;
            }

            // Block in grid cell (and not part of same group)?
            if (Playfield.grid[(int)v.x, (int)v.y] != null && Playfield.grid[(int)v.x, (int)v.y].parent != transform) 
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
