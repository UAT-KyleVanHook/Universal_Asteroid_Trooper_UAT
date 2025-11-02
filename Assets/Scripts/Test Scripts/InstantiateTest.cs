using UnityEngine;

public class InstantiateTest : MonoBehaviour
{
    public GameObject prefabToCopy;
    public Controller controllerToConnect;

    //adding audio
    //public AudioSource myAudioSource;
    //public AudioClip newAudioClip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //myAudioSource.PlayOneShot(newAudioClip);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.L))
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

            HealthComponent healthComponent = tempPawn.GetComponent<HealthComponent>();

            //check that the healthComponent isn't null. If true set the maxHeqlth to 1000.
            if (healthComponent != null)
            {
                healthComponent.maxHealth = 1000;
            }

        }
        
    }
}
