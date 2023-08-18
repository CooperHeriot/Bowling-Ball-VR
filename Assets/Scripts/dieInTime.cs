using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dieInTime : MonoBehaviour
{
    public float secs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        secs -= 1 * Time.deltaTime;

        if (secs < 0)
        {
            Destroy(gameObject);
        }
    }
}
