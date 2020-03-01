using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaE : MonoBehaviour
{
    public int vida = 3;
    public GameObject lado;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (vida<=0)
        {
            Destroy(gameObject);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="bala")
        {
            vida--;
        }
        

    }
}
