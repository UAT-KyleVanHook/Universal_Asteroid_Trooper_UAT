using UnityEngine;

public class GameQuitter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{
        //Not Needed.
    //}

    // Update is called once per frame
    void Update()
    {
        //Check if the input ofr quit has been pressed down
        if (Input.GetButtonDown("quit"))
        {
            //Log for button pressed
            Debug.Log("The quit button has been pressed. Bye!");

            //Quit Application
            Application.Quit();
        }
    }
}
