using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Clase_Partida : MonoBehaviour
{
    public bool Estado;
    public Clase_personaje MiPersonaje;
    public Clase_Nivel MiNivel;

    public Clase_Partida(bool estado)
    {
        Estado = estado;
        
    }
    public Ascendens MiMain;
    
    public void InicializarPersonaje(InputField MiNombre)
    {
        Debug.Log(MiMain.aux);
        Clase_personaje NuevoPersonaje = new Clase_personaje(0, 0, 3, 3, 3, 1, MiNombre.text, MiMain.MisPartidas[MiMain.aux]);
        MiMain.MisPartidas[MiMain.aux].MiPersonaje = NuevoPersonaje;
        MiMain.MisPartidas[MiMain.aux].MiNivel = MiMain.Nivel1;
        
        

    }
}
