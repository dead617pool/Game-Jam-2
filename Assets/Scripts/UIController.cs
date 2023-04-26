using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{

    Player player;
    Speed speed;
    Text distanceText;
    Text highScoreText;
    GameObject GameOverPanel;

    void Start()
    {
        speed = GameObject.Find("Player").GetComponent<Speed>();
        distanceText = GameObject.Find("DistanceText").GetComponent<Text>();
        highScoreText = GameObject.Find("HighScoreText").GetComponent<Text>();
        GameOverPanel = GameObject.Find("GameOverPanel");
        player = GameObject.Find("Player").GetComponent<Player>();

        GameOverPanel.SetActive(false);
        highScoreText.text = "HighScore : " + PlayerPrefs.GetInt("HighScoreText", 0).ToString();
    }

    void Update()
    {
        int distance = Mathf.FloorToInt(speed.distance);
        distanceText.text = "Score : " + distance;

        if(player.isDead)
        {
            speed.enabled = false;
            GameOverPanel.SetActive(true);

            if (distance > PlayerPrefs.GetInt("HighScoreText", 0))
            {
            PlayerPrefs.SetInt("HighScoreText", distance);
            highScoreText.text = "HighScore : " + distance.ToString();
            }

        }

        if(player.isDead && Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("s press & dead");
            SceneManager.LoadScene("Scene1");
        }
        
    }
    
}