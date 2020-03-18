using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase_objetos : MonoBehaviour
{
    public enum TipoOb {Luz,Oscuridad,Humano }
    public int IdObjeto;
    public string Nombre;
    public TipoOb TipoObjeto;
    public Clase_personaje MiPersonaje;

}
