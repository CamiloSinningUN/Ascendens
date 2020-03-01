using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void jugar(string x)
    {
        SceneManager.LoadScene(x);
    }
    
    public void salir()
    {
        Application.Quit();
    }
}
