using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionZ : MonoBehaviour
{
    // Start is called before the first frame update
    public bool De, recibirD;
    // Update is called once per frame

    void Start()
    {
        De = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "piso")
        {
            De = false;
        }

        if (other.tag == "enemigo")
        {
            recibirD = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "piso")
        {
            De = true;
        }
        
    }
}
