using JetBrains.Annotations;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Singleton variable
    public static GameManager instance;

    public List<DamageOnOverlap> damageZones;
    public int enemyCount;

    //player variables
    public Pawn playerPawn;
    //public bool isPlayerDead = false;

    //was used to determine if player is dead, not needed now.
    //bool bPlayDeathMessage = true;

    //score for game
    [Header("Score")]
    public float score;

    [Header("Lives")]
    public float playerLives;

    //timer variables
    [Header("Timer")]
    public float TimeRemaining;
    public float MaxTime;

    [Header("SoundClips")]
    public AudioClip shootingSound;
    public AudioClip explosionSound;
    public AudioClip metalSound;
    public AudioClip backgroundMusicClip;

    [Header("Audio Sources")]
    public AudioSource backgroundMusicSource;

    //screen warp boundry
    [Header("Bounding Box")]
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    //checks that the timer hasn't run out.
    public bool bTimeRanOut = false;

    private float currentTime = 1;

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

        //backgroundmusic
        backgroundMusicSource.clip = backgroundMusicClip;
        backgroundMusicSource.Play();

        //screen warp bounds
        minX = -10;
        maxX = 10;
        minY = -6;
        maxY = 6;



    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get remaining at the start of the game.
        //GetRemainingEnemies();
    }


    // Update is called once per frame
    void Update()
    {

        //Debug.Log(damageZones.Count);

        //check the current amount of enemies at this point.
        CheckRemainingEnemies();

        //check that the playerPawn is null. Check that the bool isPlayerDead is true. If playerPawn is null and isPlayerdead true, then print "Failure" onto the debug log.
        //bPlayDeathMessage checks if it should play the message continously. If true, it will allow the message to be played. 
        if (playerLives == 0 && playerPawn == null || bTimeRanOut == true)
        {
            LoseGame();
        }

        //check if the amount of damageZones equals 0. If they do, then print the word "Victory" onto the debug log.
        //bPlayDeathMessage checks if it should play the message continously. If true, it will allow the message to be played. 
        if (damageZones.Count == 0)
        {

            //WinGame();

            WinTimer();
        }


    }

    public void resetTimer()
    {
        TimeRemaining = MaxTime;
    }

    //prints to the debug log  "Victory"
    public void WinGame()
    {
        Debug.Log("Victory!");

        currentTime = 1;

        //transition to  win scene
        SceneManager.LoadScene("WinScene");

        //bPlayDeathMessage=false;


    }

    //prints to the debug log "Failure
    public void LoseGame()
    {
        Debug.Log("Failure...");

        //transition to lose screen
        SceneManager.LoadScene("GameOverScene");

        //bPlayDeathMessage = false;
    }


    //checks the remaining enemeies in the level
    public void CheckRemainingEnemies()
    {
        enemyCount = damageZones.Count;
    }


    //check that there is at least one second to determine if the game has really been won.
    //this is to make sure that if we start a new game after winnin, enmeies get a chance to spawn in before declaring winner!
    void WinTimer()
    {
        currentTime -= 1 * Time.deltaTime;

        //if timer is 0, go to win screen and set current time to 0.
        if( currentTime < 0 )
        {
            currentTime = 0;
            WinGame();

        }


    }
}
