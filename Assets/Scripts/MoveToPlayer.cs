using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    Pawn playerPawn;

    public float movementSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //try to get the pawn at the start of the game
        playerPawn = GameManager.instance.playerPawn;
        
    }

    // Update is called once per frame
    void Update()
    {
        //check if the player Pawn is true
        playerPawn = GameManager.instance.playerPawn;
        moveToPlayer();
    }

    void moveToPlayer()
    {
        //if player pawn is true, move towards the position of the pawn
        if (playerPawn != null)
        {


            this.transform.position = Vector3.MoveTowards(this.transform.position, playerPawn.transform.position, movementSpeed*Time.deltaTime);
        }
    }
}