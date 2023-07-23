using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordBehav : MonoBehaviour
{
    public bool cutting;

    public float damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (cutting == true)
        {
            if (other.GetComponent<EnemyHealth>() != null)
            {
                other.GetComponent<EnemyHealth>().Hurt(damage);
            }
        }
    }
}
