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
        //Movement Stuff
        //Move Forward when holding the W key
        if(Input.GetKey(KeyCode.W))
        {
            //if the Left OR Right shift is held down, use the TurboSpeed variable for the move speed.
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                //Tell pawn to Move Forward using the TurboSpeed
                pawn.MoveForward(pawn.turboSpeed);
            }
            else
            {
                //Tell pawn to Move Forward on their own moveSpeed
                pawn.MoveForward(pawn.moveSpeed);
            }
        }

        //Move Back when holding the S key
        if (Input.GetKey(KeyCode.S))
        {
            //if the Left OR Right shift is held down, use the TurboSpeed variable for the move speed.
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                //Tell pawn to Move Back using the TurboSpeed
                pawn.MoveBack(pawn.turboSpeed);
            }
            else
            {
                //Tell pawn to Move Backwards on their own moveSpeed
                pawn.MoveBack(pawn.moveSpeed);
            }
        }

        //Rotate Clockwise when holding the D key
        if (Input.GetKey(KeyCode.D))
        {
            //Tell pawn to Rotate Clockwise on their own moveSpeed
            pawn.RotateClockwise(pawn.rotateValue);
        }

        //Rotate CounterClockwise when holding the A key
        if (Input.GetKey(KeyCode.A))
        {
            //Tell pawn to Rotate CounterClockwise on their own moveSpeed
            pawn.RotateCounterClockwise(pawn.rotateValue);
        }



        //Teleport stuff
        //If the T key is pressed, teleport the sprite randomly
        if(Input.GetKeyDown(KeyCode.T))
        {
            pawn.TeleportRandom(pawn.randomTeleportRange_X, pawn.randomTeleportRange_Y);
        }



        //if the up arrow key is pressed, telport the sprite forward
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            pawn.TeleportForward(pawn.moveSpeed);
        }

        //if the up arrow key is pressed, telport the sprite backwards
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            pawn.TeleportBack(pawn.moveSpeed);
        }

        //if the up arrow key is pressed, telport the sprite to the left
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            pawn.TeleportLeft(pawn.moveSpeed);
        }

        //if the up arrow key is pressed, telport the sprite to the right
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            pawn.TeleportRight(pawn.moveSpeed);
        }
    }
}
