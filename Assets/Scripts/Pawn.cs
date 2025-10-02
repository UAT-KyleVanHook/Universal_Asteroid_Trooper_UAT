using UnityEngine;

public class Pawn : MonoBehaviour
{
    public float moveSpeed;
    public float rotateValue;
    //public float turboSpeed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveForward(float moveSpeed)
    {
        //Change my pawn's position -- in the forward direction, magnitude of moveSpeed.
        //Get the transform component
        //Deltatime makes it so that our speed is not tied to frame rate. it is now meters per second.
        transform.position = transform.position + ((transform.up * moveSpeed) * Time.deltaTime);
    }

    public void MoveBack(float moveSpeed)
    {
        //Change my pawn's position -- in the backward direction, magnitude of moveSpeed.
        //Get the transform component
        //Deltatime makes it so that our speed is not tied to frame rate. it is now meters per second.
        transform.position = transform.position + ((transform.up * -moveSpeed) * Time.deltaTime);
    }

    public void RotateClockwise(float rotateValue)
    {
        //Change my pawn's rotation -- in the clockwise direction, magnitude of turnSpeed.
        //Get the transform component
        //Deltatime makes it so that our speed is not tied to frame rate. it is now angles per second.
        transform.Rotate(0.0f, 0.0f, -rotateValue * Time.deltaTime);
    }

    public void RotateCounterClockwise(float rotateValue)
    {
        //Change my pawn's rotation -- in the CounterClockwise direction, magnitude of turnSpeed.
        //Get the transform component
        //Deltatime makes it so that our speed is not tied to frame rate. it is now angles per second.
        transform.Rotate(0.0f, 0.0f, rotateValue * Time.deltaTime);
    }
}

