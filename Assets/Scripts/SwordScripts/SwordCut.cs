using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCut : MonoBehaviour
{
    public float requiredSpeed, speed;

    public GameObject detector, point, point2;

    private Rigidbody drb;

    public bool cut;

    public SwordBehav SB;
    // Start is called before the first frame update
    void Start()
    {
        detector.transform.parent = null;
        point.transform.parent = null;

        drb = detector.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        point.transform.position = Vector3.Lerp(point.transform.position, point2.transform.position, speed * Time.deltaTime);

        //drb.AddForce((drb.gameObject.transform.position - point.transform.position * 10) * -1 * Time.deltaTime);

        Vector3 PullRot = drb.gameObject.transform.position - point.transform.position;
        drb.AddForce(PullRot * ((-speed * 50)) * Time.deltaTime);

        //if (Vector3.Distance(point.transform.position, detector.transform.position) > requiredSpeed)
        if (drb.velocity.magnitude > requiredSpeed)
        {
            cut = true;
            SB.cutting = true;
        } else
        {
            cut = false;
            SB.cutting = false;
        }
    }
}
