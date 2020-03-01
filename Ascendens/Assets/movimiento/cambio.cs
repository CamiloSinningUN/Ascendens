using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambio : MonoBehaviour
{
    public goomba mover;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="piso")
        {
            mover.vel = -mover.vel;
        }
    }
}
