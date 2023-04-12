using UnityEngine;


    public abstract class Bonus : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D rigidbody;
        [SerializeField] private SpriteRenderer sprite;
        [SerializeField] private BoxCollider2D hitbox;
        [SerializeField] private int pointsNeededToUnlock;
        [SerializeField] protected string name { get; set; }

        public bool IsUnlocked(int highscore) 
        { 
            return highscore >= pointsNeededToUnlock; 
        }
        public abstract void Effect(Player player);

        private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player= collision.gameObject.GetComponent<Player>();
        if (player != null )
        {
            Debug.Log("aille");
            Effect(player);
        }
    }

    }
