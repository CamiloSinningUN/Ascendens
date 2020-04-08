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
            GameObject.Find("Enemigo").GetComponent<Animator>().SetBool("live",false);
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
            GameObject.Find("Enemigo").GetComponent<Animator>().SetTrigger("hit");
            vida--;
        }
        if (other.gameObject.tag == "espada")
        {
            GameObject.Find("Enemigo").GetComponent<Animator>().SetTrigger("hit");
            vida -=2;
        }
        if (other.gameObject.tag == "esquina")
        {
            
            enemigo.aire = false;
            enemigo.propulcion = float.Parse (other.gameObject.name);
            GameObject.Find("Enemigo").GetComponent<Animator>().SetTrigger("jumping");
        }
        //que paresca que le pega cuando se acerca
        if (other.gameObject.tag=="Player")
        {
            GameObject.Find("Enemigo").GetComponent<Animator>().SetTrigger("atack");
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
