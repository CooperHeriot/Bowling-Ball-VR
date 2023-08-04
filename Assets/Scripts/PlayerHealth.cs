using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float currentHealth;
    private float maxHealth;

    public bool shielded;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }

        if (currentHealth == 0)
        {

        }
    }

    public void Hurt(float damage)
    {
        if (shielded == false)
        {
            currentHealth -= damage;
        }
    }

    public void Die()
    {

    }
}
