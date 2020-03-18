using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enabled : MonoBehaviour
{
    public Button miboton;
    
    private void Awake()
    {
        void enabled(int i)
        {
            if (i == 0)
            {
                miboton.enabled = false;
            }
        }
    }
    // Start is called before the first frame update


}
