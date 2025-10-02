using UnityEngine;
using UnityEngine.UIElements;

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
        //Move Forward
        if(Input.GetKey(KeyCode.W))
        {

            //Tell pawn to Move Forward on their own moveSpeed
            pawn.MoveForward(pawn.moveSpeed);
            
        }

        //Move Back
        if (Input.GetKey(KeyCode.S))
        {
            //Tell pawn to Move Backwards on their own moveSpeed
            pawn.MoveBack(pawn.moveSpeed);
        }

        //Rotate Clockwise
        if (Input.GetKey(KeyCode.D))
        {
            //Tell pawn to Rotate Clockwise on their own moveSpeed
            pawn.RotateClockwise(pawn.rotateValue);
        }

        //Rotate CounterClockwise
        if (Input.GetKey(KeyCode.A))
        {
            //Tell pawn to Rotate CounterClockwise on their own moveSpeed
            pawn.RotateCounterClockwise(pawn.rotateValue);
        }

    }
}
