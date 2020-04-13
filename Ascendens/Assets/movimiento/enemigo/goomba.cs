using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goomba : MonoBehaviour
{
    public float vel, propulcion, radioVista,distancia_ver, distanciaX, distanciaY,i;
    Rigidbody body;
    public bool aire,seguimiento, ataque;
    GameObject player;
    vidaE vidarestate;
    int b,d;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        body.velocity = new Vector3(5, 5, 0);
        aire = false;
        player = GameObject.FindGameObjectWithTag("Player");
        seguimiento = false;
        vidarestate = GameObject.Find("Cube (1)").GetComponent<vidaE>();
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


        distanciaX = (player.transform.position.x -transform.position.x);
        if (distanciaX >= 0)
        {
            d = 1;
           
        }
        else
        {
            d = -1;
            
        }



        if (ataque == true)
        {
            i += Time.deltaTime;
            if (i >= 0.75)
            {
                ataque = false;
                GameObject.Find("Enemigo").GetComponent<Animator>().SetBool("atack", ataque);
                i = 0;
            }

        }

        //distanciaY = (player.transform.position.y - transform.position.y);
    }
    
    public void salto()
    {
        
        body.velocity = new Vector3(vel, body.velocity.y+ propulcion, 0);
        
        
    }
    public void mover()
    {
        if (distanciaX<=15 & distanciaX >= -15 & seguimiento & vidarestate.vida>0)
        {
            if (distanciaX <= 2.5 & distanciaX >= -2.5)
            {
                body.velocity = new Vector3(0, body.velocity.y, 0);
                ataque = true;
                GameObject.Find("Enemigo").GetComponent<Animator>().SetBool("atack", ataque);
            }
            else {
                if (!ataque) {

                    GameObject.Find("Enemigo").GetComponent<Animator>().SetBool("moving", true);
                    body.velocity = new Vector3(vel * d, body.velocity.y, 0);
                    if (d >= 0)
                    {
                        GameObject.Find("Enemigo").GetComponent<SpriteRenderer>().flipX = false;
                        if (b == 1)
                        {
                            GameObject.Find("Enemigo").transform.Translate(new Vector3(2, 0, 0));
                            b = 0;
                        }
                    }
                    else
                    {
                        GameObject.Find("Enemigo").GetComponent<SpriteRenderer>().flipX = true;
                        if (b == 0)
                        {
                            GameObject.Find("Enemigo").transform.Translate(new Vector3(-2, 0, 0));
                            b = 1;
                        }

                    }
                }

                
            }

            
            distanciaY = 0;
        }
        else
        {
            if ((d==1 & !GameObject.Find("Enemigo").GetComponent<SpriteRenderer>().flipX)|| (d == -1 & GameObject.Find("Enemigo").GetComponent<SpriteRenderer>().flipX)) {
                seguimiento = true;
            } else {
                seguimiento = false;
                body.velocity = new Vector3(0, body.velocity.y, 0);
                GameObject.Find("Enemigo").GetComponent<Animator>().SetBool("moving", false);
            }
        }
    }
        
}
