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

    private void Awake()
    {
        speed = GameObject.Find("Player").GetComponent<Speed>();
        distanceText = GameObject.Find("DistanceText").GetComponent<Text>();
        highScoreText = GameObject.Find("HighScoreText").GetComponent<Text>();
        GameOverPanel = GameObject.Find("GameOverPanel");

        GameOverPanel.SetActive(false);
    }

    public bool IsPlayerDestroyed()
    {
    // UnityEngine overloads the == opeator for the GameObject type
    // and returns null when the object has been destroyed, but 
    // actually the object is still there but has not been cleaned up yet
    // if we test both we can determine if the object has been destroyed.
    return player == null && !ReferenceEquals(player, null);
    }

    void Start()
    {
        highScoreText.text = "HighScore : " + PlayerPrefs.GetInt("HighScoreText", 0).ToString();
    }

    void Update()
    {
        int distance = Mathf.FloorToInt(speed.distance);
        distanceText.text = "Score : " + distance;

        if (distance > PlayerPrefs.GetInt("HighScoreText", 0))
        {
            PlayerPrefs.SetInt("HighScoreText", distance);
            highScoreText.text = "HighScore : " + distance.ToString();
        }
        
        if (IsPlayerDestroyed())
        {
            speed.enabled = false;
            GameOverPanel.SetActive(true);
        }

        if (IsPlayerDestroyed() && Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene("Scene_jayson");
        }

    }

}