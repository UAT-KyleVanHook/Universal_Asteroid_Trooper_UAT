using UnityEngine;

public class DeathDestroyPlayer : DeathComponenet
{
    public override void Die()
    {
        //destroy the game object that this game is on.
        Destroy(gameObject);

        //alert the GameManager that the playerPawn is dead
        GameManager.instance.isPlayerDead = true;
    }
}
