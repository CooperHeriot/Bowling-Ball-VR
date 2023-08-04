using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    public bool active;

    public GameObject bird;
    public float interval = 60;
    private float begin;

    // Start is called before the first frame update
    void Start()
    {
        begin = interval;
    }

    // Update is called once per frame
    void Update()
    {
        if (active == true)
        {
            interval -= 1 *Time.deltaTime;

            if (interval <= 0)
            {
                Instantiate(bird);
                interval = begin;
            }
        }
    }
}
