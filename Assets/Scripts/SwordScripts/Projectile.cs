using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed, damage = 1;

    private GameObject playa;
    // Start is called before the first frame update
    void Start()
    {
        playa = GameObject.Find("VRRig");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        if (Vector3.Distance(transform.position, playa.transform.position) > 200)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<EnemyHealth>() != null)
        {
            collision.gameObject.GetComponent<EnemyHealth>().Hurt(damage);
            Destroy(gameObject);
        }
        if (collision.gameObject.GetComponent<birt>() != null)
        {
            collision.gameObject.GetComponent<birt>().death();
            Destroy(gameObject);
        }
    }
}
