using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goomba : MonoBehaviour
{
    public float vel, propulcion;
    Rigidbody body;
    public bool aire;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        body.velocity = new Vector3(5, 5, 0);
        aire = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (aire)
        {
        salto();
        }
        else
        {
           
        mover();
        }

    }
    
    public void salto()
    {
        

        body.velocity = new Vector3(vel, body.velocity.y, 0);
        
    }
    public void mover()
    {

        GameObject.Find("Enemigo").GetComponent<Animator>().SetBool("moving", true);      
        body.velocity = new Vector3(vel, body.velocity.y+ propulcion, 0);
    }
}
