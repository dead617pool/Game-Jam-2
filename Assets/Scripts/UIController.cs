using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    Speed speed;
    Text distanceText;
    public Text highScoreText;

    private void Awake()
    {
        speed = GameObject.Find("Player").GetComponent<Speed>();
        distanceText = GameObject.Find("DistanceText").GetComponent<Text>();
        highScoreText = GameObject.Find("HighScoreText")?.GetComponent<Text>();
    }

    void Start()
    {
        if (highScoreText != null)
        {
            highScoreText.text = PlayerPrefs.GetInt("HighScoreText", 0).ToString();
        }
    }


    void Update()
    {
        int distance = Mathf.FloorToInt(speed.distance);
        distanceText.text = "Score : " + distance;

        if (distance > PlayerPrefs.GetInt("HighScoreText", 0))
        {
            PlayerPrefs.SetInt("HighScoreText", distance);
            if (highScoreText != null)
            {
                highScoreText.text = distance.ToString();
            }
        }
        
    }

}
