using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///Clase nivel.
///</summary>
///<remarks>
///Da atributos y funciones a los niveles.
///</remarks>

public class Clase_Nivel : MonoBehaviour
{
    public enum TipoNi{Normal,Boss}
    public string nombre;
    public int Dificultad;
    public TipoNi TipoNivel;
    public ArrayList MisEnemigos;
    public Clase_Partida[] MisPartidas;

    ///<summary>
    ///Asigna unos atributos iniciales al nivel.
    ///</summary>

    public Clase_Nivel(string nombre, int dificultad, TipoNi tipoNivel)
    {
        this.nombre = nombre;
        Dificultad = dificultad;
        TipoNivel = tipoNivel;
        MisEnemigos = new ArrayList();
        MisPartidas = new Clase_Partida[3]; 
    }
}
