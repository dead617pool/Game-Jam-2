using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    Speed speed;
    Text distanceText;
    Text highScoreText;

    private void Awake()
    {
        speed = GameObject.Find("Player").GetComponent<Speed>();
        distanceText = GameObject.Find("DistanceText").GetComponent<Text>();
        highScoreText = GameObject.Find("HighScoreText").GetComponent<Text>();
    }

    void Start()
    {
        highScoreText.text = "HighScore : " + PlayerPrefs.GetInt("HighScoreText", 0).ToString();
        int distance = Mathf.FloorToInt(speed.distance);
        distanceText.text = "Score : " + distance;
    }
}