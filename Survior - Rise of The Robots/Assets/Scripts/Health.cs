using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public static Health Playerhealth;
    
    public float maxHealth =100;
    public float health;
    public Slider HealthUI;
    public Gradient gradient;
    public Image fill;
    public int lives=3;
    

    void Start()
    {
        health = maxHealth;
        fill.color = gradient.Evaluate(1f);
        
    }

    
    void Update()
    {
        HealthUI.value = health;
        fill.color = gradient.Evaluate(HealthUI.normalizedValue);
    }

    public void takeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
            //test line 
            gameObject.SetActive(true);
            Start();
            FindObjectOfType<LevelManager>().respawnplayer();
            // new line 
            //(new NavigationController()).GoToGameOverScene();
        }
    }
    void Die()
    {
        gameObject.SetActive(false);
        HealthUI.value = 0;
        lives--;
        if (lives == 0)
        {
            (new NavigationController()).GoToGameOverScene();
        }
    }

    public void healHealth(int heal)
    {
        health += heal;
        if (health >= 100)
        {
            health = maxHealth;
        }
    }

}
