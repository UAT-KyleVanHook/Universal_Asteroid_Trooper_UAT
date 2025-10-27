using UnityEngine;

public abstract class HealthComponent : MonoBehaviour
{
    //originally this was the main health comp
    //now I made two inherited health comps: player and enemy
    public float currentHealth;
    public float maxHealth;

    public abstract void TakeDamage(float amount);

    public abstract bool isAlive();

    public abstract void Heal(float amount);
    public abstract void Die();
}
