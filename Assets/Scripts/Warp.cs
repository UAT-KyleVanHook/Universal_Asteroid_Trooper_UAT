using UnityEngine;

public class Warp : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckBounds();
    }

    //check the x and y values of this object. If it is larger or smaller than values, Warp it to the other side.
    void CheckBounds()
    {

        //Debug.Log(this.transform.position.x);

        //if object goes past the minX (left side), teleport to the opposite side
        if (this.transform.position.x < GameManager.instance.minX)
        {
            
            this.transform.position = new Vector2((float)GameManager.instance.maxX, transform.position.y); 
        }

        //if this object goes past the maxX (right side), teleport to the opposite side.
        if (this.transform.position.x > GameManager.instance.maxX)
        {
            this.transform.position = new Vector2((float)GameManager.instance.minX, transform.position.y);
        }


        //if object goes past the minY (doawnward side), teleport to the opposite side
        if (this.transform.position.y < GameManager.instance.minY)
        {

            this.transform.position = new Vector2(transform.position.x, (float)GameManager.instance.maxY);
        }

        //if this object goes past the maxY (Upward side), teleport to the opposite side.
        if (this.transform.position.y> GameManager.instance.maxY)
        {
            this.transform.position = new Vector2(transform.position.x, (float)GameManager.instance.minY);
        }


    }
}
