using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public GameObject[] groups;
    // Start is called before the first frame update
    void Start()
    {
        //spawnNext();
    }

    void Awake()
    {
        spawnNext();
    }

    

    //Spawns a Block shape out of the prefabs
    //Blocks are set in the Spawner object in the inspector
    public void spawnNext()
    {
        int i = Random.Range(0, groups.Length);

        Instantiate(groups[i], transform.position, Quaternion.identity);
        Debug.Log("block spawned");
    }
}
