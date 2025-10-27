using UnityEngine;

public abstract class HealthComponent : MonoBehaviour
{

    public float currentHealth;
    public float maxHealth;

    public abstract void TakeDamage(float amount);

    public abstract bool isAlive();

    public abstract void Heal(float amount);
    public abstract void Die();
}
