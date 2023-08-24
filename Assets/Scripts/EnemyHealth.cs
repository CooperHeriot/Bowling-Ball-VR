using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float currentHealth;

    public float maxHealth;

    public GameObject win;

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
            die();
        }
    }

    public void Hurt(float damage)
    {
        currentHealth -= damage;

        print("dsffds");
    }

    public void die()
    {
        win.SetActive(true);
    }
}
