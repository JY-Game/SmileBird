using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject deathEffect;
    float health = 3f;
    public static int EnemiesAlive = 0;

    private void Start()
    {
        EnemiesAlive++;
    }

    void OnCollisionEnter2D(Collision2D colinfo)
    {
        //Debug.Log(colinfo.relativeVelocity.magnitude);
        if (colinfo.relativeVelocity.magnitude > health)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);

        EnemiesAlive--;
        if (EnemiesAlive <= 0 )
        {
            Debug.Log("LEVEl WINNING");
        }

        Destroy(gameObject);
    }
}
