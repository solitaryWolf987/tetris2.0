using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextBlock : MonoBehaviour
{
    public static NextBlock instance;

    public GameObject[] groups;
    public GameObject nextBlock;

    private void Awake()
    {
        instance = this;
        
    }

    public void SpawnNextBlock(int next)
    {
        
        Debug.Log(next);
        GameObject newNextBlock = Instantiate(groups[next], transform.position, Quaternion.identity);
        Destroy(nextBlock);
        nextBlock = newNextBlock;
    }

}
