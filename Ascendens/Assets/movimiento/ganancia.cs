using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ganancia : MonoBehaviour
{
    public datos cantidad;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerStay(Collider other)
    {
        if (other.tag=="Player")
        {
            cantidad.dinero += 1;
            Destroy(gameObject);
        }
    }
}
