using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class birt : MonoBehaviour
{
    public GameObject target, poof;
    public float speed = 1, force = 1;
    private quaternion qua;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        target = GameObject.Find("hitBox");
    }

    // Update is called once per frame
    void Update()
    {
       // transform.LookAt(target.transform.position);
       qua = Quaternion.LookRotation(transform.position - target.transform.position);

       transform.rotation = Quaternion.Slerp(transform.rotation, qua, speed * Time.deltaTime);

       rb.AddForce(((transform.forward * -1) * force * 10) * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 7)
        {
            if (collision.gameObject.GetComponent<SwordBehav>().cutting == true)
            {
                print("dsad");
                death();
            }          
        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerHealth>() != null)
        {
            other.gameObject.GetComponent<PlayerHealth>().Hurt(1);

            rb.AddForce(((transform.forward) * force * 55) * Time.deltaTime, ForceMode.Impulse);
        }
    }

    public void death()
    {
        Instantiate(poof);

        Destroy(gameObject);
    }
}
