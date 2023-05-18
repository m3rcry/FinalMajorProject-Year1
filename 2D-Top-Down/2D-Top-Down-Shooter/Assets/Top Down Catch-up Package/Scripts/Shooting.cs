using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Fix this script 
//Add this script to your player so you can fire bullets

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public GameObject firePoint;
    public float damageAmount, attackRange, fireRate = 0.5f, nextFire = 0.2F;
    public LayerMask enemyLayer;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        if (Input.GetButton("Fire1") && Time.time > nextFire) 
     {
         nextFire = Time.time + fireRate;
         GameObject clone = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
     }
    }


    void Shoot(){
        GameObject clone = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
        }
}
