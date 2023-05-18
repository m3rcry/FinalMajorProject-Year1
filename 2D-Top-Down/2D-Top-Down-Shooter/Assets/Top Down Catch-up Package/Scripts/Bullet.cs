using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Fix everything in this script.
// You need to make a bullet prefab which has a Collider & a Rigidbody

public class Bullet : MonoBehaviour
{
    public GameObject bullet;
    Rigidbody2D rb;
    GameObject enemy;
    public float bulletSpeed, bulletDamage, nextFire = 0.2F, fireRate = 0.3F;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * bulletSpeed);
        enemy = GameObject.FindWithTag("Target");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Target"))
        {
            other.GetComponent<Enemy>().TakeDamage(bulletDamage);
        }
    }

    void Update()
    {
        Destroy(bullet, 4);
    }
}
