using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float currentHealth;
    private float maxHealth;

    public bool shielded;

    public GameObject gameOver, blud;

    public Image imag;
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
            Die();
        }
    }

    public void Hurt(float damage)
    {
        if (shielded == false)
        {
            currentHealth -= damage;
            blud.SetActive(false);
            blud.SetActive(true);

            imag.fillAmount = currentHealth / maxHealth;
        }
    }

    public void Die()
    {
        gameOver.SetActive(true);
    }
}
