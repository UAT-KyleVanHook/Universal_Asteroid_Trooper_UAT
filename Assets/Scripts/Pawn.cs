using UnityEngine;
using UnityEngine.UIElements;

public class Pawn : MonoBehaviour
{
    private Transform spriteTransform;
    public float randomTeleportRange_X;
    public float randomTeleportRange_Y;

    public float moveSpeed;
    public float rotateValue;
    public float turboSpeed;

    //teleport range for arrow keys
   // public float teleportRange;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Get the transform for this sprit
        spriteTransform = this.gameObject.GetComponent<Transform>();
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


    // Teleport the sprit to a random space on the field.
    public void TeleportRandom(float randomTeleportRange_X, float randomTeleportRange_Y)
    {
        //Check that the spriteTransform is not Null.
        //if true, set the X & Y positions in the transform to a random number between the teleport range variable (Variable must be positive!).
        if (spriteTransform != null)
        { 
            spriteTransform.position = new Vector3(Random.Range(-randomTeleportRange_X, randomTeleportRange_X), Random.Range(-randomTeleportRange_Y, randomTeleportRange_Y), 0.0f);
        }
    }


    //Teleport to a new position in front of the sprite. Uses the movespeed to determine the teleport range.
    //Getting rid of the transform.position in the formula will make it so it transforms to the global position, not the local position. 
    public void TeleportForward(float moveSpeed)
    {
        transform.position = transform.position + (transform.up * moveSpeed);
    }

    //Teleport to a new position in the back of the sprite. Uses the movespeed to determine the teleport range.
    //Getting rid of the transform.position in the formula will make it so it transforms to the global position, not the local position. 
    public void TeleportBack(float moveSpeed)
    {
        transform.position = transform.position + (transform.up * -moveSpeed);
    }

    //Teleport to a new position left of the sprite. Uses the movespeed to determine the teleport range.
    //Getting rid of the transform.position in the formula will make it so it transforms to the global position, not the local position. 
    public void TeleportLeft(float moveSpeed)
    {
        transform.position = transform.position + (transform.right * -moveSpeed);
    }

    //Teleport to a new position Right of the sprite. Uses the movespeed to determine the teleport range.
    //Getting rid of the transform.position in the formula will make it so it transforms to the global position, not the local position. 
    public void TeleportRight(float moveSpeed)
    {
        transform.position = transform.position + (transform.right * moveSpeed);
    }
}

