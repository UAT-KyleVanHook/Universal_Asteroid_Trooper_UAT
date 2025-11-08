using UnityEngine;

public class DeathMeteorDestroy : DeathComponenet
{
    public GameObject spawnObject;
    public int numOfObjects;
    public Transform spawnTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Die()
    {
        int counter = 0;

        //spawn object until counter equals numOfObjects
        while (counter < numOfObjects)
        {

            //spawn two smaller meteors
            Instantiate(spawnObject, spawnTransform.position, spawnTransform.rotation);
            counter++;
        }

        //destroy the game object that this component is on.
        Destroy(gameObject);

    }
}
