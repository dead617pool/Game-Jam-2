using UnityEngine;

namespace Assets.Scripts
{
    public abstract class Bonus : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D rigidbody;
        [SerializeField] private SpriteRenderer sprite;
        [SerializeField] private BoxCollider2D hitbox;
        [SerializeField] private int pointsNeededToUnlock;
        [SerializeField] private string name { get; }

        public bool IsUnlocked(int hitscore) { return hitscore >= pointsNeededToUnlock; }

        public abstract void Effect(Player player);

    }
}