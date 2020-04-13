using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class barraVida : MonoBehaviour
{
    public datos vid;
    public Image vida;

    public float longitud;
    // Start is called before the first frame update
    void Start()
    {
        vid.vida = vid.vidaMax;
    }

    // Update is called once per frame
    void Update()
    {
        longitud= (float)vid.vida / (float)vid.vidaMax;
        vida.transform.localScale = new Vector2(longitud,1);
        if (vid.vidaMax < vid.vida)
        {
            vid.vida = vid.vidaMax;
        }
        if (vid.vida <= 0)
        {
            vid.vida = 0;
            SceneManager.LoadScene("pruebas");
        }
    }
}
