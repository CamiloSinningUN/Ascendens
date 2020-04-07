using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Dinero;
    public GameObject bala,disparador, sprite,golpeI, golpeD;
    public estilo pos;
    public colisionI LI;
    public colisionZ LD;
    public bool cortar, empuje;
    public datos inve;
    public salto placa;
    public float velocidad = 2f,corte=0,empujeL,empujeA,i;
    Rigidbody body;
    public int direccion;
    void Start()
    {
        body = GetComponent<Rigidbody>();
        body.velocity = new Vector3(0, 0, 0);
        golpeI.SetActive(false);
        golpeD.SetActive(false);
        empuje = false;
    }

    // Update is called once per frame
    void Update()
    {
        cuerpo();
        movimiento();
        disparo();
    }

    void disparo()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            estilo pos = bala.GetComponent<estilo>();
            pos.direccion = direccion;
            Instantiate(bala, disparador.transform.position, Quaternion.Euler(0, 0, 90));
        }
        if (LD.recibirD || LI.recibirD)
        {
            i += 0.1f*Time.deltaTime;
            if (placa.plataforma==true & i>0.05)
            {
                i = 0;
                LD.recibirD = false;
                LI.recibirD = false;
                empuje = false;
                sprite.GetComponent<Animator>().SetBool("daño", false);
                
            }
        }
    }
    void cuerpo()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            sprite.GetComponent<Animator>().SetBool("atacking", true);

            cortar = true;

        }

        if (cortar & direccion == -1)
        {
            corte += 0.1f * Time.deltaTime;
            if (corte < 0.055 & corte > 0.02)
            {
                golpeI.SetActive(true);
            }
            if (corte > 0.055)
            {
                cortar = false;
                golpeI.SetActive(false);
                sprite.GetComponent<Animator>().SetBool("atacking", false);

                corte = 0;
            }
        }
        if (cortar & direccion == 1)
        {
            corte += 0.1f * Time.deltaTime;
            if (corte < 0.055 & corte > 0.02)
            {
                golpeD.SetActive(true);
            }
            if (corte > 0.055)
            {
                cortar = false;
                golpeD.SetActive(false);
                sprite.GetComponent<Animator>().SetBool("atacking", false);

                corte = 0;
            }
        }
    }


    void movimiento ()
    {
        if (!LD.recibirD & !LI.recibirD)
        {
            if (Input.GetKey(KeyCode.D) & LD.De)
            {
                body.velocity = new Vector3(velocidad, body.velocity.y, 0);
                sprite.GetComponent<Animator>().SetBool("Moving", true);
                sprite.GetComponent<SpriteRenderer>().flipX = false;
                direccion = 1;
            }
            if (Input.GetKey(KeyCode.A) & LI.iZ)
            {
                body.velocity = new Vector3(-velocidad, body.velocity.y, 0);
                sprite.GetComponent<Animator>().SetBool("Moving", true);
                sprite.GetComponent<SpriteRenderer>().flipX = true;
                direccion = -1;
            }
            if (!Input.GetKey("a") && !Input.GetKey("d"))
            {
                sprite.GetComponent<Animator>().SetBool("Moving", false);
            }
        }
        else
        {
            
            
            if (!empuje)
            {
                if (LD.recibirD)
                {
                    body.velocity = new Vector3(-empujeL, empujeA, 0);
                    inve.vida--;
                }
                if (LI.recibirD)
                {
                    body.velocity = new Vector3(empujeL, empujeA, 0);
                    inve.vida--;
                }
                sprite.GetComponent<Animator>().SetBool("daño", true);
                empuje = true;
            }
            else
            {
                body.velocity = new Vector3(body.velocity.x, body.velocity.y, 0);
            }
            
        }

    }
    

}
    



