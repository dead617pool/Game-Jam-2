using UnityEditor;
using UnityEngine;


public class Shield : Bonus
{

    public override void Effect(Player player)
    {
        player.IncrementShieldNumber();
    }
} 
