using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ascendens : MonoBehaviour
{
    public Clase_Partida[] MisPartidas = new Clase_Partida[3];
    public Clase_Nivel[] MisNiveles = new Clase_Nivel[3];
    public Clase_Nivel Nivel1 = new Clase_Nivel("Nivel_1",1,Clase_Nivel.TipoNi.Normal);
    public Clase_Nivel Nivel2 = new Clase_Nivel("Nivel_2", 2, Clase_Nivel.TipoNi.Normal);
    public Clase_Nivel Nivel3 = new Clase_Nivel("Nivel_3", 3, Clase_Nivel.TipoNi.Boss);
    public int aux;
    public void Nueva_o_Continuar(int boton)
    {
        
        if (MisPartidas[boton]==null)
            
        {
            SceneManager.LoadScene("Inicia_Sesión");
            Clase_Partida NuevaPartida = new Clase_Partida(true);
            MisPartidas[boton] = NuevaPartida;
        }
        else
        {
            SceneManager.LoadScene(MisPartidas[boton].MiNivel.nombre);
        }
        aux = boton;
        PlayerPrefs.SetInt("MiBoton", aux);
    }  
  
}
