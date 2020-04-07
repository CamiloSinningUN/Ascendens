using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///<summary>
///Clase personaje.
///</summary>
///<remarks>
///Permite controlar al avatar, las estadísticas y variables que este posee.
///</remarks>


public class Clase_personaje : MonoBehaviour
{
   public int Dinero,IdPersonaje,Vida,Fuerza,Mana,Dificultad;
   public string Nombre;
   public Clase_Partida MiPartida;
   public ArrayList MisObjetos;
   public float timer;
    public float velocidad = 2f;
    public Rigidbody body;

    ///<summary>
    ///Asigna estadisticas iniciales al personaje.
    ///</summary>

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

    ///<summary>
    ///Actualiza la informacion en cada frame.
    ///</summary>
    
    void Update()

    {
        if (Input.GetKeyDown("f"))

        {
            gameObject.GetComponent<Animator>().SetBool("atacking", true);           
        }

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
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 4500f));
            gameObject.GetComponent<Animator>().SetBool("Jumping", true);
        }
       
            
    }

    ///<summary>
    ///Permite saber si el personaje salta o si consigue una moneda.
    ///</summary>

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag=="piso")
        {
            puedesaltar = true;
            gameObject.GetComponent<Animator>().SetBool("Jumping", false);
        }
        if (collision.transform.tag == "Moneda")
        {
            agregarDinero(1);
        }
    }

    ///<summary>
    ///Agrega dinero al personaje.
    ///</summary>
    
    public void agregarDinero(int i)
    {
        Dinero = Dinero + i;
        Debug.Log(Dinero);
    }
}

