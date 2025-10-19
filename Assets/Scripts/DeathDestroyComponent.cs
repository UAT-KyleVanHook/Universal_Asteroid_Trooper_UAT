using UnityEngine;

public class DeathDestroyComponent : DeathComponenet
{
    public override void Die()
    {
        //destroy the game object that this component is on.
        Destroy(gameObject);
    }
}
