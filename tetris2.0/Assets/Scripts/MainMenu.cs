using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{

    public Text scoreText;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        float highScore = PlayerPrefs.GetFloat("highScore");
        scoreText.text = "High Score: " + highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
