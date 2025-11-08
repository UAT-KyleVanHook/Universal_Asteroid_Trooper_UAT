using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{

    public Image TimerImage;
    public TMP_Text bottomText;

    public TMP_Text scoreText;
    float UIScore;

    public TMP_Text enemyCounter;
    int CurrentEnemies;

    //lives text and image
    //public Image TimerImage;
    public TMP_Text livesText;
    float currentPlayerLives;

    //bool bTimeRanOut = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //start the timer
        GameManager.instance.resetTimer();

        //set initial texts
        bottomText.text = "Hello World!";
        scoreText.text = "Score:";
        enemyCounter.text = "Enemies:";
        livesText.text = "Lives x";

        //get the amount of enemies from GameManager
        CurrentEnemies = GameManager.instance.enemyCount;
        currentPlayerLives = GameManager.instance.playerLives;

    }

    // Update is called once per frame
    void Update()
    {
        GetCurrentEnemies();

        UpdateTimer();

        UpdateScoreText();

        UpdateEnemyCount();

        UpdateLivesCount();
    }

    //updates the timer on screen
    void UpdateTimer()
    {
        //update the timer in the Canvas
        GameManager.instance.TimeRemaining -= Time.deltaTime;
        TimerImage.fillAmount = GameManager.instance.TimeRemaining / GameManager.instance.MaxTime;

        float displayTimeRemaining = Mathf.Floor(GameManager.instance.TimeRemaining);
        bottomText.text = "Time Remaining: " + displayTimeRemaining;
        bottomText.fontSize = 20;

        //if time runs out, declare game over.
        if (displayTimeRemaining <= 0 && GameManager.instance.bTimeRanOut == false)
        {
            
            Debug.Log("Time ran out.");
            GameManager.instance.bTimeRanOut = true;
            //GameManager.instance.LoseGame();
           
        }

    }

    //update the score of the UI Manager score text
    void UpdateScoreText()
    {

        UIScore = GameManager.instance.score;

        scoreText.text = "Score: " + UIScore; 

    }
   
    void UpdateEnemyCount()
    {
        //update current enemies and the text
        //CurrentEnemies = GameManager.instance.damageZones.Count;

       // Debug.Log("Current Enemeies: " + GameManager.instance.startingEnemies);

        enemyCounter.text = "Enemies: " + CurrentEnemies;

    }

    void UpdateLivesCount()
    {
        currentPlayerLives = GameManager.instance.playerLives;

        //Debug.Log("CurrentPlayerLives: " + currentPlayerLives);

        livesText.text = "Lives x " + currentPlayerLives;
    }

    void GetCurrentEnemies()
    {
        CurrentEnemies = GameManager.instance.damageZones.Count;
    }

}
