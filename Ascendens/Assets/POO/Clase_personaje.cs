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
}

