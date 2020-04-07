using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class datos : MonoBehaviour
{
    public int dinero, cantidadFlechas,vida,vidaMax=15;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (vidaMax<vida)
        {
            vida = vidaMax;
        }
        if (vida <=0 )
        {
            //muerte 
        }
    }
}
