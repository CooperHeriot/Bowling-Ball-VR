using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinBehav : MonoBehaviour
{
    public GameObject Cont;

    //public float x, z;

    public Vector3 pos;
    public float dist;
    public bool knockOvr, don;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        Cont.GetComponent<pinControl>().upper();
    }

    // Update is called once per frame
    void Update()
    {
        /*x = transform.localRotation.x;
        z = transform.localRotation.z;

        if (x > 30 || x < -30)
        {
            knockOvr = true;   
        }

        if (z > 30 || z < -30)
        {
            knockOvr = true;
        }*/

        if (Vector3.Distance(pos, transform.position) > dist)
        {
            knockOvr = true;
        }

        if (knockOvr == true && don == false)
        {
            Cont.GetComponent<pinControl>().kill();
            don = true;
        }
    }
}
