using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estilo : MonoBehaviour
{
    private Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        body.velocity = new Vector3(10, 0, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag!="Player")
        {
            Destroy(gameObject);
        }
        
    }
}
