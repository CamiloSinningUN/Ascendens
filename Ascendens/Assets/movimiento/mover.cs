using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public float velocidad = 2f;
    public Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        body.velocity = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    
    private void Update()
    {
        
            if (Input.GetKey(KeyCode.D))
            {
                body.velocity = new Vector3(velocidad, body.velocity.y, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                body.velocity = new Vector3(-velocidad, body.velocity.y, 0);
            }
        
        
        
        
    }
    
}