using JetBrains.Annotations;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Singleton variable
    public static GameManager instance;

    public List<DamageOnOverlap> damageZones;

    public Pawn playerPawn;
    public bool isPlayerDead = false;

    bool bPlayDeathMessage = true;

    //this is  the only GameManager that can exist. We want this to happen before start
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        //Create new List to store DamageOnOVerlap's
        damageZones = new List<DamageOnOverlap>();


    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //check if the amount of damageZones equals 0. If they do, then print the word "Victory" onto the debug log.
        //bPlayDeathMessage checks if it should play the message continously. If true, it will allow the message to be played. 
        if (damageZones.Count == 0 && bPlayDeathMessage)
        {
            WinGame();
        }


        //check that the playerPawn is null. Check that the bool isPlayerDead is true. If playerPawn is null and isPlayerdead true, then print "Failure" onto the debug log.
        //bPlayDeathMessage checks if it should play the message continously. If true, it will allow the message to be played. 
        if (playerPawn == null && isPlayerDead == true && bPlayDeathMessage == true)
        {
            LoseGame();
        }

    }

    //prints to the debug log  "Victory"
    void WinGame()
    {
        Debug.Log("Victory!");

        bPlayDeathMessage=false;

        //used to set the editor to isPlaying is false. This quits the game in the editor
        //WARNING: This must be removed when building the game file. It will cause crashes otherwise.
        //UnityEditor.EditorApplication.isPlaying = false;
    }

    //prints to the debug log "Failure
    void LoseGame()
    {
        Debug.Log("Failure...");

        bPlayDeathMessage = false;

        //used to set the editor to isPlaying is false. This quits the game in the editor
        //WARNING: This must be removed when building the game file. It will cause crashes otherwise.
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
