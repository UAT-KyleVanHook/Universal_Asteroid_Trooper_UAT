using UnityEngine;

public class DeathRecenterComponent : DeathComponenet
{
    public override void Die()
    {
        //Move the object to 0,0,0.
        transform.position = Vector3.zero;

    }
}
