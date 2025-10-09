using UnityEngine;

public class DeathRecenterComponent : DeathComponenet
{
    public override void Die()
    {
        //Move the object to 0,0,0.
        transform.position = Vector3.zero;

        //Also do the die form the parent class (DeathComponenet)
        base.Die();
    }
}
