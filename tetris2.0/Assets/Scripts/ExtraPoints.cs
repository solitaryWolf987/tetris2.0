using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraPoints : MonoBehaviour
{

    Vector2 randomPosition;
    score = ScoringSystem.instance;
    public float xRange = 7f;
    public float yRange = 13f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score.getCurrentScore() == 1000f)
        {
            float xPosition = Random.Range(0 - xRange, 0 + xRange);
            float yPosition = Random.Range(0 - yRange, 0 + yRange);
            randomPosition = new Vector2(xPosition, yPosition);
            transform.position = randomPosition;
        }
    }
}
