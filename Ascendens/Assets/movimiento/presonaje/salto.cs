using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salto : MonoBehaviour
{
    public GameObject sprite;
    public Rigidbody body;
    public bool plataforma;
    public float fuerza;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.W) && other.tag =="piso")
        {
            body.velocity = new Vector3(body.velocity.x, fuerza, 0);
            sprite.GetComponent<Animator>().SetBool("Jumping", true);
        }
        else if (other.tag == "piso")
        {
            sprite.GetComponent<Animator>().SetBool("Jumping", false);
        }
        if (other.tag == "piso")
        {
            plataforma = true;
        }
        if (!(other.tag == "piso"))
        {
            plataforma = false;
        }
    }
}
