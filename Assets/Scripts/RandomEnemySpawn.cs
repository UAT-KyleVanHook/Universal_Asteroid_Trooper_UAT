using UnityEngine;

public class RandomEnemySpawn : MonoBehaviour
{
    [Header("Spawned Prefabs")]
    public GameObject meteorPrefab;
    public GameObject ufoPrefab;

    [Header("Spawn Amount")]
    public int spawnAmount;

    [Header("UFO Spawn Percentage")]
    [Tooltip("This only takes double between 0 and 100")]
    public int spawnPercentage;

    //counter for while loop
     int counter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        counter = 0;
        SpawnEnemy();
        //counter = 0;

    }

    // Update is called once per frame
    void Update()
    {

        //while counter is less than spawnAmount, spawn a single object each loop.
       // while (counter < spawnAmount)
        //{

           // SpawnEnemy();

        //}

    }

    void SpawnEnemy()
    {

        //do this based on spawnAmount
        while (counter < spawnAmount) 
        {
            //X and Y values for the random enemy spawn.
            float x1 = 0;
            float y1 = 0;


            //make sure that x1 is not 0 and is at least 1 unit away from player.
            do
            {
                x1 = Random.Range(GameManager.instance.minX, GameManager.instance.maxX);
            }
            while (x1 < -8 || x1 > 8);

            //make sure that y1 is not 0 and is at least 1 unit away from player.
            do
            {
                y1 = Random.Range(GameManager.instance.minX, GameManager.instance.maxX);
            }
            while (y1 < -8 || y1 > 8);




            //get random vector position of the game area
            Vector3 spawnPosition = new Vector3(x1, y1, 0f);

        //Spawn a random number between 0 and 100. The 101 is because Random.Range is exclusive of the later number.
        int randomChance = Random.Range(0, 101);

        //if randomChance is less than  or equal to the spawnPercentage, spawn a UFOPrefab on the map. Otherwise spawn a large meteor.
        if (randomChance <= spawnPercentage)
        {
            Instantiate(ufoPrefab, spawnPosition, Quaternion.identity);
        }
        else
        {
            Instantiate(meteorPrefab, spawnPosition, Quaternion.identity);
        }

        counter++;

    }

    }
}
