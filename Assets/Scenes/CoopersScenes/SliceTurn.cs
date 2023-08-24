using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SliceTurn : MonoBehaviour
{
    public BookController BK;
    public bool fdafsdfg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fdafsdfg == true)
        {
            BK.NextPage();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            if (other.gameObject.GetComponent<SwordBehav>().cutting == true)
            {
                SceneManager.LoadScene("Cooperlvl1");
            }
        }

    }
}
