using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Clase_personaje : MonoBehaviour
{
    
   public int Dinero,IdPersonaje,Vida,Fuerza,Mana,Dificultad;
   public string Nombre;
   public Clase_Partida MiPartida;
   public ArrayList MisObjetos;

    public Clase_personaje(int dinero, int idPersonaje, int vida, int fuerza, int mana, int dificultad, string nombre, Clase_Partida miPartida)
    {
        Dinero = dinero;
        IdPersonaje = idPersonaje;
        Vida = vida;
        Fuerza = fuerza;
        Mana = mana;
        Dificultad = dificultad;
        Nombre = nombre;
        MiPartida = miPartida;
        MisObjetos = new ArrayList();
    }
    bool puedesaltar = false;
    void Update()
    {
        if (Input.GetKey("d"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(10000f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("Moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;

        }
        if (Input.GetKey("a"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-10000f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("Moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (!Input.GetKey("a")&&!Input.GetKey("d"))
        {
            gameObject.GetComponent<Animator>().SetBool("Moving", false);
        }
        if (Input.GetKeyDown("w")&&puedesaltar)
        {
            puedesaltar = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 2000f));
        }
       
            
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag=="piso")
        {
            puedesaltar = true;
        }
        if (collision.transform.tag == "Moneda")
        {
            agregarDinero(1);
        }
    }
    public void agregarDinero(int i)
    {
        Dinero = Dinero + i;
        Debug.Log(Dinero);
    }
}

