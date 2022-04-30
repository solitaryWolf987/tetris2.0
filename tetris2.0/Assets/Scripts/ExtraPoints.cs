using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                Debug.Log(starObject.name);
                targetScore += 100;
                hasSpawned = true;

                

            }
            //Object.Destroy(image, 5f);
        }
    }


    public void destroyStar()
    {

        Debug.Log("destroy");
        hasSpawned = false;
    }

    


}
