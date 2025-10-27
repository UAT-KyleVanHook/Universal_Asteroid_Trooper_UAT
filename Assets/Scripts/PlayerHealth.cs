using UnityEngine;

public class PlayerHealth : HealthComponent
{

    //iherited by healthcomp
    //variables are still in it

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void TakeDamage(float amount)
    {

        currentHealth = currentHealth - amount;

        //if object isn't alive, set health to zero and tell it to die.
        if (!isAlive())
        {
            currentHealth = 0;
            Die();
        }

    }

    public override bool isAlive()
    {
        //check that the health is more than zero
        if (currentHealth > 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public override void Heal(float amount)
    {

        currentHealth = currentHealth + amount;

        //check that the current health isn't larger than the maxhealth. If true, set health to maxhealth
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

    }

    public override void Die()
    {
        //TODO: handle death in the health component
        DeathComponenet death = GetComponent<DeathComponenet>();

        //check that the object can die
        if (death != null)
        {
            death.Die();
        }
    }
}
