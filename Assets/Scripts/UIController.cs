using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    Speed speed;
    Text distanceText;
    Text highScoreText;
    // public GameObject GameOverPanel;
    // public bool isHit;

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
            highScoreText.text = "HighScore : " + PlayerPrefs.GetInt("HighScoreText", 0).ToString();
        }
    }

    // void FixedUpdate()
    // {
    //     if (!isHit && Input.GetKeyDown(KeyCode.Z))
    //     {
    //         Time.timeScale = 1f;
    //         GameOverPanel.SetActive(false);
    //     }
    // }

    void Update()
    {
        int distance = Mathf.FloorToInt(speed.distance);
        distanceText.text = "Score : " + distance;

        if (distance > PlayerPrefs.GetInt("HighScoreText", 0))
        {
            PlayerPrefs.SetInt("HighScoreText", distance);
            if (highScoreText != null)
            {
                highScoreText.text = "HighScore : " + distance.ToString();
            }
        }
        
        // if (isHit)
        // {
        //     GameOverPanel.SetActive(true);
        //     Time.timeScale = 0f;
        // }
    }

}
