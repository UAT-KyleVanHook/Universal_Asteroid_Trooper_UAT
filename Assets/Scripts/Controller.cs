using UnityEngine;

public class Controller : MonoBehaviour
{
    public Pawn pawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Based on inputs, send commands to Pawn
        MakeDecisions();
    }

    private void MakeDecisions()
    {
        if(Input.GetKey(KeyCode.W))
        {
            //Tell pawn to Move Forward on their own moveSpeed
            pawn.MoveForward(pawn.moveSpeed);
        }

    }
}
