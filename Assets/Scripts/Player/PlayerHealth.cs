using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public float health = 5f;
    private float maxHealth = 5f;
    public Material playerMaterial;
    private bool immortality;

    public DisplayHealth DisplayHealth;
    private void Start()
    {
        DisplayHealth.SetupHealth(maxHealth);
        DisplayHealth.ShowHealthPoint(health);
    }

    public void Damage(float damage)
    {
        if (immortality == true)
        {
            return;
        }

        health -= damage;
        immortality = true;
        Invoke("SetMortality", 1.5f);
        DisplayHealth.ShowHealthPoint(health);

        if (health <= 0)
        {
            health = 0;
            DisplayHealth.ShowHealthPoint(health);
            DiePlayer();
            
        }
    }
    public void SetMortality()
    {
        immortality = false;
    }
    public void DiePlayer()
    {
        gameObject.SetActive(false);
    }
    public void AddHealth(float CountHealth)
    {
        health += CountHealth;
        if (health > maxHealth) health = maxHealth;
        DisplayHealth.ShowHealthPoint(health);
    }
}
