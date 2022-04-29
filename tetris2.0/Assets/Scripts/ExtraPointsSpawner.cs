using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraPointsSpawner : MonoBehaviour
{
    
    public GameObject Star;
    private bool hasSpawned = false;
    float targetScore = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnStar();
    }

    public void spawnStar()
    {
        if (ScoringSystem.instance.getCurrentScore() >= targetScore)
        { 
            if (hasSpawned == false)
            {
            
                Instantiate(Star, transform.position, Quaternion.identity);
                Debug.Log("star spawned");
                hasSpawned = true;
                targetScore += 100;
            }
                
        
        }
    }   

    public void destroyStar()
    {
        Destroy(Star);
        hasSpawned = false;
    }


}
