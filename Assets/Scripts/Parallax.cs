using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    public float depth = 1;
    Speed speed;    
    public float pointOfLeave = -40;
    public float pointOfEnter = 40;
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

        if (pos.x <= pointOfLeave)
            pos.x = pointOfEnter ;
            
        transform.position = pos;
    }
}
