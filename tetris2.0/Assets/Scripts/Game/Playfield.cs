using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Class to create the playfield of the game.
 */


public class Playfield : MonoBehaviour
{
    public static int w = 10;
    public static int h = 20;
    public static Transform[,] grid = new Transform[w, h];
    
    public static Vector2 roundVec2(Vector2 v) 
    {
        return new Vector2(Mathf.Round(v.x), Mathf.Round(v.y));
    }

    //Checks if the blocks are inside the border of the game
    public static bool insideBorder(Vector2 pos)
    {
        return ((int)pos.x >= 0 &&
                (int)pos.x < w &&
                (int)pos.y >= 0);
    }

    //Deletes specific row when called.
    public static void deleteRow(int y)
    {
        for (int x = 0; x < w; ++x)
        {
            Destroy(grid[x, y].gameObject);
            grid[x, y] = null;
        }
    }

    //Moves rows down one when row below is deleted.
    public static void decreaseRow(int y)
    {
        for (int x = 0; x < w; ++x)
        {
            if (grid[x, y] != null)
            {
                // Move one towards bottom
                grid[x, y - 1] = grid[x, y];
                grid[x, y] = null;

                // Update Block position
                grid[x, y-1].position += new Vector3(0, -1, 0);
            }
        }
    }

    //Moves rows down one when row below are decreased.
    public static void decreaseRowsAbove(int y)
    {
        for (int i = y; i < h; ++i)
        {
            decreaseRow(i);
        }
    }

    //Checks if the row provided is full.
    public static bool isRowFull(int y)
    {
        for (int x = 0; x < w; ++x)
        {
            if (grid[x, y] == null)
            {
                return false;
            }
        }
        return true;
    }

    //Calls all functions required for the deletion of a row.
    public static void deleteFullRows()
    {
        for (int y = 0; y < h; ++y)
        {
            if (isRowFull(y))
            {
                deleteRow(y);
                decreaseRowsAbove(y + 1);
                scoreIncrease();
                --y;
            } 
        }
    }

    //Adds 50 points to the score
    public static void scoreIncrease()
    {
        ScoringSystem.instance.IncreaseScore(50);
    }
}
