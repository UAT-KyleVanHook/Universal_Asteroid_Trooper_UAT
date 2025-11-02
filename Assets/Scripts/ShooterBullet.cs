using UnityEngine;

public class ShooterBullet : Shooter
{
    [Header("Bullet")]
    public GameObject bulletPrefab;
    public Transform firePoint;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {
 

    }

    public override void Shoot()
    {

         Debug.Log("Shooting Bullet!");

        //Instatiate a projectile prefab, using the position of an Empty transform object attached to the player prefab.
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        

    }

}
