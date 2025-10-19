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
        if(damageZones.Count == 0)
        {
            Debug.Log("Victory!");
        }


        //check that the playerPawn is null. Check that the bool isPlayerDead is true. If playerPawn is null and isPlayerdead true, then print "Failure" onto the degub log.
        if(playerPawn == null && isPlayerDead == true)
        {
            Debug.Log("Failure...");
        }

    }
}
