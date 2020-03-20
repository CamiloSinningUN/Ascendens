using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///<summary>
///Clase partida.
///</summary>
///<remarks>
///Maneja las partidas.
///</remarks>

public class Clase_Partida : MonoBehaviour
{
    public bool Estado;
    public Clase_personaje MiPersonaje;
    public Clase_Nivel MiNivel;

    ///<summary>
    ///Asigna el estado inicial de la partida.
    ///</summary>
 
    public Clase_Partida(bool estado)
    {
        Estado = estado;
        
    }

    public Ascendens MiMain;

    ///<summary>
    ///Crea un nuevo personaje para la partida.
    ///</summary>
    

    public void InicializarPersonaje(InputField MiNombre)
    {
   
        int aux1 = PlayerPrefs.GetInt("MiBoton");
        Clase_personaje NuevoPersonaje = new Clase_personaje(0, 0, 3, 3, 3, 1, MiNombre.text, MiMain.MisPartidas[aux1]);
        MiMain.MisPartidas[aux1].MiPersonaje = NuevoPersonaje;
        MiMain.MisPartidas[aux1].MiNivel =MiMain.Nivel1;
        
        

    }
}
