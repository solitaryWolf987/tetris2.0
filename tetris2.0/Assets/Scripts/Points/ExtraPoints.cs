using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Class to spawn and remove the extra points sprites.
 */

public class ExtraPoints : MonoBehaviour
{
    public static ExtraPoints instance;

    Vector2 randomPosition;
    public GameObject image;
    public float xRange = 7f;
    public float yRange = 11f;
    private bool hasSpawned = false;
    private float targetScore = 100;
    private GameObject starObject;


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
        * Spawns the sprite in a random location on the game board
        */
        if (ScoringSystem.instance.getCurrentScore() >= targetScore)
        {
            if (hasSpawned == false)
            {
                float xPosition = Random.Range(3, xRange);
                float yPosition = Random.Range(3, yRange);
                randomPosition = new Vector2(xPosition, yPosition);
                transform.position = randomPosition;
                starObject = Instantiate(image, transform.position, Quaternion.identity);
                starObject.name = "Star game object";
                //Debug.Log(starObject.name);
                targetScore += 100;
                hasSpawned = true;

                

            }
        }
    }

    //Lets the update method know that the sprite can be spawned again when the condition is met
    public void destroyStar()
    {

        //Debug.Log("destroy");
        hasSpawned = false;
    }

    


}
