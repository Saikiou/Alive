using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public int health = 30;
    public GameObject deathEffect;
    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <=0)
    {
        Die();
    }

}    

    // Update is called once per frame
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
