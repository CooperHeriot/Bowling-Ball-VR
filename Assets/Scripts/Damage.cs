using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public float amount = 1;
    public bool goAwayOnHit;
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
        if (other.GetComponent<PlayerHealth>() != null)
        {
            other.GetComponent<PlayerHealth>().Hurt(amount);

            if (goAwayOnHit == true)
            {
                Destroy(gameObject);
            }
        }
    }
}
