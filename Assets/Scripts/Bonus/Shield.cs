using UnityEngine;


    public class Shield : Bonus
    {
        public override void Effect(Player player)
        {
            player.IncrementShieldNumber();
        }

    private void OnTriggerEnter2D(Collider2D collision)
        {
            Player player= collision.gameObject.GetComponent<Player>();
            if (player != null )
            {
                Effect(player);
                Destroy(gameObject);
            }
    }

    }
