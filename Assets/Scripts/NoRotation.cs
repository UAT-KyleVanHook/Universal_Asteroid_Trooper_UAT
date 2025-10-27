using UnityEngine;

public class NoRotation : MonoBehaviour
{
    Vector3  StartPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get the start position of thsi object
        StartPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //prevents this object from rotating
        transform.rotation = Quaternion.identity;

        //keeps the object above the rotating object.
        transform.position = StartPosition;
        
    }
}
