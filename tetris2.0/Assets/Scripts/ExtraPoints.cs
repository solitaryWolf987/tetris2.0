using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraPoints : MonoBehaviour
{

    Vector2 randomPosition;
    public GameObject image;
    public float xRange = 7f;
    public float yRange = 13f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (ScoringSystem.instance.getCurrentScore() >= 100f && ScoringSystem.instance.getCurrentScore() <= 101f)
        {
            float xPosition = Random.Range(0, xRange);
            float yPosition = Random.Range(0, yRange);
            randomPosition = new Vector2(xPosition, yPosition);
            transform.position = randomPosition;
            Instantiate(image, transform.position, Quaternion.identity);
        }
    }
}
