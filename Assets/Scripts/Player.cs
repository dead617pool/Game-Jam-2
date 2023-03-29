using UnityEngine;

public class Player : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer;
    public Collider2D Collider;
    public Rigidbody2D Rigidbody;

    private int compteurShield=0;
    public void IncrementShieldNumber() { compteurShield++; }  
    public void TakeHit()
    {
        if(compteurShield==0)
            Destroy(gameObject);
        compteurShield--;
    }
    void Start()
    {

    }
}
