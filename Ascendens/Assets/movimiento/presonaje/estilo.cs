using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estilo : MonoBehaviour
{
    private Rigidbody body;
    public float t;
    public int direccion;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        if (direccion==0)
        {
            direccion = 1;
        }
        body.velocity = new Vector3(direccion * 10, 0, 0);
        t += Time.deltaTime;
        if (t>10)
        {
            Destroy(gameObject);

        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Player"  & !other.isTrigger)
        {
            Destroy(gameObject);
            Debug.Log(other.tag);
        }
        
        
    }
}
