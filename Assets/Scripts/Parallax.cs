using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    public float depth = 1;

    Speed speed;

    private void Awake()
    {
        speed = GameObject.Find("Player").GetComponent<Speed>();
    }

    void Start()
    {
        
    }


    void FixedUpdate()
    {
        float realVelocity = speed.velocity.x / depth;
        Vector2 pos = transform.position;

        pos.x -= realVelocity * Time.fixedDeltaTime;

        if (pos.x <= -20)
            pos.x = 20;
            
        transform.position = pos;
    }
}
