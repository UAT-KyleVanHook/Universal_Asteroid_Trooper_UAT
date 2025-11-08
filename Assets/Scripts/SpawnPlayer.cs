using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    //track current lives
    float currentLives;

    //player prefab
    public GameObject prefabToCopy;
    //player controller
    public Controller controllerToConnect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get lives at the start of the game
        currentLives = GameManager.instance.playerLives;
        
    }

    // Update is called once per frame
    void Update()
    {
        //if there is no playerPawn in the scen, spawn one
        if (GameManager.instance.playerPawn == null && currentLives > 0)
        {
            SpawnNewPlayer();
        }

    }

    public void SpawnNewPlayer()
    {
        if (currentLives > 0)
        {

            GameObject tempPawn;
            //Spawn at 0,0,0 with a rotation (Quaterion) that is unchanged. Type cast as a GameObject. If it can't type cast, it will make it null.
            tempPawn = Instantiate(prefabToCopy, Vector3.zero, Quaternion.identity) as GameObject;


            //check that tempPawn is not null, then get the component of tempPawn, as a pawn. Check that the pawnComponent isn't null, then connect the controller to this pawn.
            if (tempPawn != null)
            {
                Pawn pawnComponent = tempPawn.GetComponent<Pawn>();
                if (pawnComponent != null)
                {
                    controllerToConnect.pawn = pawnComponent;


                    //set tempPawn to playerpawn in GameManager 
                    GameManager.instance.playerPawn = pawnComponent;
                }

            }

        }
    }
}
