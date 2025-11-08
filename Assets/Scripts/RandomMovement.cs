using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    //speed of object
    public int moveSpeed;

    //X and Y values for direction
    float randDirectionX;
    float randDirectionY;

    Vector3 direction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get two random X and Y values for direction
        randDirectionX = Random.Range(-1f,1f);
        randDirectionY = Random.Range(-1f, 1f);

        direction = new Vector3(randDirectionX, randDirectionY, 0f);
    }

    // Update is called once per frame
    void Update()
    {

       //immediatly start moving 
        transform.position = transform.position + direction * (moveSpeed * Time.deltaTime);

    }
}
