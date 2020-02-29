using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ObtenerNick : MonoBehaviour
{
    public InputField Nickname;
    public Clase_Cuenta name;
    // Start is called before the first frame update
    public void setNick()
    {
        int i = 0;
        while (name.Nick[i]!="" && i<2)
        {  
            i = i + 1;
        }
        if (i==2)
        {
            Debug.Log("no hay mas espacio de partidas");
        }
        else
        {
            name.Nick[i] = Nickname.text;
                
        }
        Debug.Log(name.Nick[i]);
    }
}
