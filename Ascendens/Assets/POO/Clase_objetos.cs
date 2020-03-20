using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///Clase objetos.
///</summary>
///<remarks>
///Da atributos y funciones a los objetos.
///</remarks>

public class Clase_objetos : MonoBehaviour
{
    public enum TipoOb {Luz,Oscuridad,Humano }
    public int IdObjeto;
    public string Nombre;
    public TipoOb TipoObjeto;
    public Clase_personaje MiPersonaje;

    public Ascendens mipartida;

    ///<summary>
    ///Elimina las monedas luego de ser tomadas.
    ///</summary>

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
