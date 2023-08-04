using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordBehav : MonoBehaviour
{
    public bool cutting;

    public float damage = 1;

    public bool shooting;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       /* if (shooting== true)
        {

        }*/
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

        if (other.transform.tag == "rs" || other.transform.tag == "ls")
        {
            shooting = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "rs")
        {
            shooting = false;
        }
    }
}
