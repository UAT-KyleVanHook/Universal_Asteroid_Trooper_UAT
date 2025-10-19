using UnityEngine;

public class Projectile : MonoBehaviour
{

    public int moveSpeed;
    public int bulletDamage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        //If the projectile hasn't collided with an object with a health component or collider, then destroy after 5 secs after spawing.
        Destroy(this.gameObject, 5f);

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //immediatly start moving 
        transform.position = transform.position + ((transform.up * moveSpeed) * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        HealthComponent otherHealth = other.gameObject.GetComponent<HealthComponent>();

        //check that the collided object has a health component. If true do damage.
        if (otherHealth != null)
        {
            otherHealth.TakeDamage(bulletDamage);
        }

        //when colliding with another object, destroy this object.
        Destroy(this.gameObject);

    }
}
