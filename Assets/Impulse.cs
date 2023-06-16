using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : MonoBehaviour
{
    public Vector3 Dir, dir2;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddTorque(Dir);
        rb.AddForce(dir2);
    }

    // Update is called once per frame
    void Update()
    {
        //Dir.x = rb.ang
    }
}
