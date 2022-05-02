using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Class to spawn and delete a sprite to gain extra time.
 */

public class ExtraTime : MonoBehaviour
{

    public static ExtraTime instance;
    Vector2 randomPosition;
    public GameObject TimeImage;
    public float xRange = 7f;
    public float yRange = 11f;
    private bool hasSpawned = false;
    private float targetScore = 120;
    private GameObject plusObject;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        /**
        * Spawns the sprite in a random location on the game board.
        */
        if (ScoringSystem.instance.getCurrentScore() >= targetScore)
        {
            if (hasSpawned == false)
            {
                float xPosition = Random.Range(3, xRange);
                float yPosition = Random.Range(3, yRange);
                randomPosition = new Vector2(xPosition, yPosition);
                transform.position = randomPosition;
                plusObject = Instantiate(TimeImage, transform.position, Quaternion.identity);
                plusObject.name = "Plus game object";
                Debug.Log(plusObject.name);
                targetScore += 120;
                hasSpawned = true;
            }
        }
    }

    //Lets the update method know that the sprite can be spawned again when the condition is met
    public void destroyTime()
    {
        //Debug.Log("destroy");
        hasSpawned = false;
    }
}
