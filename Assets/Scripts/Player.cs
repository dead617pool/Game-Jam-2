using UnityEngine;

public class Player : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer;
    public Collider2D Collider;
    public Rigidbody2D Rigidbody;
    
    public void TakeHit()
    {
        Destroy(gameObject);
    }
    void Start()
    {

    }
}
