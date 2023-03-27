using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            TakeDamage(20);
        }

        if (currentHealth == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if  (collision.CompareTag("Trap"))
        {
            TakeDamage(20);
        }          
        
    }

}