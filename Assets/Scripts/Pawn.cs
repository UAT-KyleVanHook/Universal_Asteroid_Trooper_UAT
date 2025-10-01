using UnityEngine;

public class Pawn : MonoBehaviour
{
    public float moveSpeed;
    public float turnSpeed;


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
        transform.position = transform.position + (Vector3.up * moveSpeed);
    }
}
