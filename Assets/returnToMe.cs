using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returnToMe : MonoBehaviour
{
    private Vector3 pos;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -10)
        {
            transform.position = pos;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
