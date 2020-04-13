using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaE : MonoBehaviour
{
    public int vida = 7;
    goomba enemigo;
    public float i=0;
    bool ataque;
    public GameObject apariencia;
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
            apariencia.GetComponent<Animator>().SetBool("live",false);
            enemigo.vel = 0;
            enemigo.tag = "piso";
            gameObject.GetComponent<BoxCollider>().center = new Vector3(1, -0.5f, 0);
            gameObject.GetComponent<BoxCollider>().size= new Vector3(1, 0, 0);
            GameObject.Find("izquierdo").GetComponent<BoxCollider>().enabled = false;
            GameObject.Find("derecho").GetComponent<BoxCollider>().enabled = false;

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
            vida -=2;
        }
        if (other.gameObject.tag == "esquina")
        {
            enemigo.aire = true;
            enemigo.propulcion = float.Parse (other.gameObject.name);
            apariencia.GetComponent<Animator>().SetBool("jumping", true);
            apariencia.GetComponent<Animator>().SetBool("moving", false);
        }
        //que paresca que le pega cuando se acerca
        

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "piso")
        {
            apariencia.GetComponent<Animator>().SetBool("jumping", false);
            apariencia.GetComponent<Animator>().SetBool("moving", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "esquina")
        {
            
            enemigo.aire = false ;
        }
    }
}
