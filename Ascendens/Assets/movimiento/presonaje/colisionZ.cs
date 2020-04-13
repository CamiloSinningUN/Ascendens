using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionZ : MonoBehaviour
{
    // Start is called before the first frame update
    public bool De, recibirD;
    public int daño;
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
            daño = 1;
        }
        if (other.tag == "dañoE")
        {
            recibirD = true;
            daño = int.Parse(other.gameObject.name); 
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
