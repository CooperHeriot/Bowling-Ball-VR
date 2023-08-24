using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float currentHealth;
    private float maxHealth;

    public bool shielded;

    public GameObject gameOver, blud;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = currentHealth;
        blud.SetActive(false);
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
            blud.SetActive(false);
            blud.SetActive(true);
        }
    }

    public void Die()
    {
        gameOver.SetActive(true);
    }
}
