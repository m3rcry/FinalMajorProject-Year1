using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Fix everything in this script to make everything work.
// Your enemies will need to colliders on them and their tags setting to target. 

public class Enemy : MonoBehaviour
{
    public GameObject playerObject;
    public float enemySpeed, enemyHealth, attackRate, attackDelay, damageAmount, attackDistance;

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.FindWithTag("Player");    
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > attackDelay)
        {
            EnemyMove();
            if(Vector2.Distance(playerObject.transform.position, transform.position) <= attackDistance)
            {
                playerObject.GetComponent<PlayerHealth>().playerHealth -= damageAmount;
                attackDelay = Time.time + attackRate;
            }
        }
    }

    void EnemyMove()
    {
        float step = enemySpeed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, playerObject.transform.position, step);
    }

    public void TakeDamage(float amount)
    {
        enemyHealth -= amount;
        if(enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
