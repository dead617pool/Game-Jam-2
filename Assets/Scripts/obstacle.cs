using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public float depth = 1;

    Speed speed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("aille");
            Destroy(collision.gameObject);
        }
    }

    private void Awake()
    {
        speed = GameObject.Find("SpeedManagerMob1").GetComponent<Speed>();
    }
    private void FixedUpdate()
    {
        float realVelocity = speed.velocity.x / depth;
        Vector2 pos = transform.position;

        pos.x -= realVelocity * Time.fixedDeltaTime;
        if (pos.x < -35)
        {
            Destroy(gameObject);
        }
        transform.position = pos;
    }
}
