using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Class to spawn the blocks on the game grid when function is called.
 */

public class Spawner : MonoBehaviour
{
    public GameObject[] groups;
    public int i;
    // Start is called before the first frame update
    void Start()
    {
        i = Random.Range(0, groups.Length);
        spawnNext();
    }

    void Awake()
    {
        //spawnNext();
    }

    

    //Spawns a Block shape out of the prefabs
    //Blocks are set in the Spawner object in the inspector
    public void spawnNext()
    {
        //NextBlock.instance.Reset();
        int j = Random.Range(0, groups.Length);
        SpawnNextBlock(j);
        Instantiate(groups[i], transform.position, Quaternion.identity);
        i = j;
        
    }

    public void SpawnNextBlock(int next)
    {
        //Debug.Log(next);
        NextBlock.instance.SpawnNextBlock(next);
    }
}
