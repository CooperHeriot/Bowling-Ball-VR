using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCut : MonoBehaviour
{
    public float requiredSpeed, speed;

    public GameObject detector, point;

    public bool cut;

    public SwordBehav SB;
    // Start is called before the first frame update
    void Start()
    {
        detector.transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        detector.transform.position = Vector3.Lerp(detector.transform.position, point.transform.position, speed * Time.deltaTime);

        if (Vector3.Distance(point.transform.position, detector.transform.position) > requiredSpeed)
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
