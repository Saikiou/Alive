using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthBar : MonoBehaviour
{
    public int maxHealth = 50;
    public int currentHealth;
    public HealthBar healthBar;
    public GameObject SoldierDeath;
    
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update(Collision collision)
    {
        Zombie other = collision.gameObject.GetComponent<Zombie>();
        if(other)
        {
            TakeDamage(5);
        }
        if(currentHealth <=0)
        {
            Die();
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
    void Die()
    {
        Instantiate(SoldierDeath, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
