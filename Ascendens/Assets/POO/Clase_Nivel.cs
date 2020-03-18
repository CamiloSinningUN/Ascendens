using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase_Nivel : MonoBehaviour
{
    public enum TipoNi{Normal,Boss}
    public int Dificultad;
    public TipoNi TipoNivel;
    public ArrayList MisEnemigos; 
    public Clase_Partida[] MisPartidas = new Clase_Partida[3];
}
