using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase_personaje : MonoBehaviour
{
    public int dinero;
    public int id;
    public int vida;
    public int mana;
    public int fuerza;
    public string nick;
    public int dificultad;
    public int minivel;

    public Clase_personaje(int dinero, int id, int vida, int mana, int fuerza, string nick, int dificultad,int minivel)
    {
        this.dinero = dinero;
        this.id = id;
        this.vida = vida;
        this.mana = mana;
        this.fuerza = fuerza;
        this.nick = nick;
        this.dificultad = dificultad;
        this.minivel = minivel;
    }
}
