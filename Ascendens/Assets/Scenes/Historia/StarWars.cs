using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarWars : MonoBehaviour
{
    public float velocidad = 80;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posicion = transform.position;
        Vector3 vectorArriba = transform.TransformDirection(0,1,0);
        posicion += vectorArriba * velocidad * Time.deltaTime;
        transform.position = posicion;
    }
}
