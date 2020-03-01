using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salto : MonoBehaviour
{
    public Rigidbody body;
    public float fuerza;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.W))
        {
            body.velocity = new Vector3(body.velocity.x, fuerza, 0);
        }
    }
}
