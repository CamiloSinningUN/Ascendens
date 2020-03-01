using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goomba : MonoBehaviour
{
    public int vel;
    Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        body.velocity = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector3(vel, 0, 0);
    }
}
