using UnityEngine;


    public abstract class Bonus : MonoBehaviour
    {
        public float depth = 1;
   
        [SerializeField] private Rigidbody2D rigidbody;
        [SerializeField] private SpriteRenderer sprite;
        [SerializeField] private BoxCollider2D hitbox;
        [SerializeField] private int pointsNeededToUnlock;
        [SerializeField] protected string name { get; set; }
        private Speed speed;

    public bool IsUnlocked(int highscore) => highscore >= pointsNeededToUnlock;
        public abstract void Effect(Player player);
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
