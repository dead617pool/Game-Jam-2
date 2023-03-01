using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    Speed speed;
    Text distanceText;

    private void Awake()
    {
        speed = GameObject.Find("Player").GetComponent<Speed>();
        distanceText = GameObject.Find("DistanceText").GetComponent<Text>();
    }

    void Start()
    {
        
    }


    void Update()
    {
        int distance = Mathf.FloorToInt(speed.distance);
        distanceText.text = "Score : " + distance;
    }
}
