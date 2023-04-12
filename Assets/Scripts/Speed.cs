using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Speed : MonoBehaviour
{

    public Vector2 velocity;
    public float maxXVelocity = 200;
    public float maxAcceleration = 7;
    public float acceleration = 7;
    public float distance = 0;



    private void FixedUpdate()
    {
        distance += (velocity.x / 5) * Time.fixedDeltaTime;

        Vector2 pos = transform.position;

        float velocityRatio = velocity.x / maxXVelocity;
        acceleration = maxAcceleration * (1 - velocityRatio);

        velocity.x += acceleration * Time.fixedDeltaTime;
        if (velocity.x >= maxXVelocity)
        {
            velocity.x = maxXVelocity;
        }
        transform.position = pos;
    }
}