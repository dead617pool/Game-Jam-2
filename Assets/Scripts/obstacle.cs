using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public float depth = 1;

    Speed speed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player= collision.GetComponent<Player>();
        Debug.Log("trigger");
        if (player != null )
        {
            Debug.Log("aille");
            player.TakeHit();
            Destroy(this.gameObject);

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

        transform.position = pos;
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
