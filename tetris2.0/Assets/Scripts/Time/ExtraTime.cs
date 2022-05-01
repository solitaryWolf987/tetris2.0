using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public void destroyTime()
    {
        Debug.Log("destroy");
        hasSpawned = false;
    }
}
