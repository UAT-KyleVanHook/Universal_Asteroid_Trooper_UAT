using UnityEngine;

public class Rotate : MonoBehaviour
{
    //rotation speed
    public float rotateSpeed;

    //rotation gets the Vector of this object its attached to.
    // in the case of a 2D object, only the Z vector should be modified to rotate.
    [SerializeField] private Vector3 rotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //continously rotates an object
        transform.Rotate(rotation * (rotateSpeed * Time.deltaTime));
    }
}
