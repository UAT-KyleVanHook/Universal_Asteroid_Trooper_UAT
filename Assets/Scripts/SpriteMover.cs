using UnityEngine;

public class SpriteMover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Transform spriteTransform;
    
    //Create a variable for the Transform
    void Start()
    {
        //Get the transform for this sprit
        spriteTransform = this.gameObject.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        //Check if any key is pressed down
        //Check that the spriteTransform is not Null.
        //if true, set the X & Y positions in the transform to a random number between -5 & 5.
        if (Input.anyKeyDown)
        {
            if (spriteTransform != null)
            {
                spriteTransform.position = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), 0.0f);
            }
        }
        
    }
}
