using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionI : MonoBehaviour
{
    
    public bool iZ, recibirD;
    public int daño;
    // Update is called once per frame
    void Start()
    {
        iZ = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="piso")
        {
            iZ = false;
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
            iZ = true;
        }
        
    }


}
