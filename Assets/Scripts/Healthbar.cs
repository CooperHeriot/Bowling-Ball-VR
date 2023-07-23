using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public EnemyHealth TARGET;
    public Image bar;

    private float max, cur;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cur = TARGET.currentHealth;
        max = TARGET.maxHealth;

        bar.fillAmount = cur / max;
    }
}
