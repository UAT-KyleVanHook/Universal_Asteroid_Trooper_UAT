using UnityEngine;

public class DamageOnOverlap : MonoBehaviour
{
    public bool isInstaKill;
    public float damageDone;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //get healthComponenet
        HealthComponent otherHealth = other.gameObject.GetComponent<HealthComponent>();

        //check that the object has the health component
        if (otherHealth != null)
        {
            // if instakill is true, immeadiatly kill on trigger
            if (isInstaKill == true)
            {
                //check that object has a death componenet
                DeathComponenet otherDeath = other.gameObject.GetComponent<DeathComponenet>();

                if (otherDeath != null)
                {
                    otherHealth.Die();
                }
     
            }

            //otherwise just take damage
            otherHealth.TakeDamage(damageDone);
        }

    }
}
