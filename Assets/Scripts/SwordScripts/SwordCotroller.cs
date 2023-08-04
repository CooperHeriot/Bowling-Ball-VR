using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCotroller : MonoBehaviour
{
    public SwordCut left, right;

    public LayerMask LM, LM2;

    public bool lLaserOn, rLaserOn, shielding;

    public PlayerHealth PH;

    public GameObject shield, laser, cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(left.point2.transform.position, left.point2.transform.forward, out hit, 999, LM2) && Physics.Raycast(right.point2.transform.position, right.point2.transform.forward, out hit, 999, LM2))
        {
            shielding = true;
        } else
        {
            shielding = false;
        }

        if (shielding == true)
        {
            shield.SetActive(true);
            PH.shielded = true;

            shield.transform.position = ((left.gameObject.transform.position + right.gameObject.transform.position) / 2);
            shield.transform.rotation = cam.transform.rotation;
        } else
        {
            shield.SetActive(false);
            PH.shielded = false;
        }


        if (Physics.Raycast(left.point2.transform.position, left.point2.transform.forward,out hit , 999, LM))
        {
            lLaserOn = true;
        } else
        {
            lLaserOn = false;
        }

        if (Physics.Raycast(right.point2.transform.position, right.point2.transform.forward, out hit, 999, LM))
        {
            rLaserOn = true;
        }
        else
        {
            rLaserOn = false;
        }

        if (lLaserOn == true && rLaserOn == false)
        {
            if (left.shoot == true)
            {
                Instantiate(laser, left.point2.transform.position, left.point2.transform.rotation);
                left.shoot = false;
            }
        }

        if (lLaserOn == false && rLaserOn == true)
        {
            if (right.shoot == true)
            {
                Instantiate(laser, right.point2.transform.position, right.point2.transform.rotation);
                right.shoot = false;
            }
        }

        // if (left.)
    }
}
