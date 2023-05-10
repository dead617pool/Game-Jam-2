using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class Player : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer;
    public Collider2D Collider;
    public Rigidbody2D Rigidbody;
    public Animator animator;

    public int compteurShield=0;
    public bool isDead = false;
    public void IncrementShieldNumber() { compteurShield++; }  
    public void TakeHit()
    {
        if(compteurShield==0)
            isDead = true;
            
        compteurShield--;
    }
    void Update()
    {
        if(isDead)
        {   
            endFrame();
        }
    }

    IEnumerator endFrame()
    {
        yield return new WaitForEndOfFrame();
        Destroy(gameObject);
    }
}
