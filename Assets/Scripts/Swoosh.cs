using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swoosh : MonoBehaviour
{
    public LineRenderer LR;

    public GameObject Point1, Point2;
    // Start is called before the first frame update
    void Start()
    {
        LR = GetComponent<LineRenderer>();  
    }

    // Update is called once per frame
    void Update()
    {
        LR.SetPosition(0, Point1.transform.position);
        LR.SetPosition(1, Point2.transform.position);
    }
}
