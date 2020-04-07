using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaE : MonoBehaviour
{
    public int vida = 3;
    public goomba enemigo;
    // Start is called before the first frame update
    void Start()
    {
        enemigo = GetComponent<goomba>();
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
        if (other.gameObject.tag == "espada")
        {
            vida-=2;
        }
        if (other.gameObject.tag == "esquina")
        {

            enemigo.aire = false;
            enemigo.propulcion = float.Parse (other.gameObject.name);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "esquina")
        {
            enemigo.aire = true ;
        }
    }
}
