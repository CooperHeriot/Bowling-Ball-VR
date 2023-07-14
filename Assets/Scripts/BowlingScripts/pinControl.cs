using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinControl : MonoBehaviour
{
    public float knockedOvr, requir;
    public GameObject win;
    // Start is called before the first frame update
    void Start()
    {
        win.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (knockedOvr == requir)
        {
            win.SetActive(true);
        }
    }

    public void kill()
    {
        knockedOvr += 1;
    }

    public void upper()
    {
        requir += 1;
    }
}
