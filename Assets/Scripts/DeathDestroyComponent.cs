using UnityEngine;

public class DeathDestroyComponent : DeathComponenet
{
    public override void Die()
    {
        //destroy the game object that this game is on.
        Destroy(gameObject);
    }
}
