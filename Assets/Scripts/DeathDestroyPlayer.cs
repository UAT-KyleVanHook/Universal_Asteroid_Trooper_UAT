using UnityEngine;

public class DeathDestroyPlayer : DeathComponenet
{
    public override void Die()
    {
        //destroy the game object that this component is on.
        Destroy(gameObject);

        //play a death sound for the player at the position of destruction.
        AudioSource.PlayClipAtPoint(GameManager.instance.explosionSound, this.transform.position, 1.0f);

        //alert the GameManager that the playerPawn is dead
        //GameManager.instance.isPlayerDead = true;

        //remove life
        GameManager.instance.playerLives -= 1;
    }
}
