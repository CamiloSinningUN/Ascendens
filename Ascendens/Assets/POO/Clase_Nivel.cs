using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase_Nivel : MonoBehaviour
{
    public enum TipoNi{Normal,Boss}
    public string nombre;
    public int Dificultad;
    public TipoNi TipoNivel;
    public ArrayList MisEnemigos;
    public Clase_Partida[] MisPartidas;

    public Clase_Nivel(string nombre, int dificultad, TipoNi tipoNivel)
    {
        this.nombre = nombre;
        Dificultad = dificultad;
        TipoNivel = tipoNivel;
        MisEnemigos = new ArrayList();
        MisPartidas = new Clase_Partida[3]; 
    }
}
