using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public ArrayList misusuarios=new ArrayList();
    public InputField minombre;
    public InputField miNick;
    public InputField miraza;
    public Clase_Cuenta micuenta;
    public string nombredespues;
   
    
    
    
    
    public void asignarnombre()
    {
        //bool existe = false;
        /* (Clase_Cuenta micuenta in misusuarios)
        {
           if(micuenta.nombre==minombre.text)
            {
                existe = true;
            }
        }
        if (existe)
        {

        }
        else
        {
            Clase_Cuenta NuevaCuenta = new Clase_Cuenta(minombre.text);
            misusuarios.Add(NuevaCuenta);
            Debug.Log(NuevaCuenta.nombre);
            
        }*/
        Clase_Cuenta NuevaCuenta = new Clase_Cuenta(minombre.text);
        misusuarios.Add(NuevaCuenta);
         nombredespues = NuevaCuenta.nombre;
    }

    public void crearpartida()
    {
        Clase_personaje NuevoPersonaje = new Clase_personaje(0, 1, 10, 10, 10, "camilo",1,1) ;
        foreach (Clase_Cuenta miusuario in misusuarios )
        {
            Debug.Log("aida");
            if (nombredespues == miusuario.nombre)
            {
                miusuario.mispersonajes.Add(NuevoPersonaje);
            }
        }
        SceneManager.LoadScene("Nivel_1");
        
    }
    public void reanudarpartida()
    {

    }

}
