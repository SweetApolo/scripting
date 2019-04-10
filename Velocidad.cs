using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocidad : MonoBehaviour
{

    Rigidbody mRg;
    Renderer col;
    float vel;
    // Start is called before the first frame update
    void Start()
    {
        mRg = GetComponent<Rigidbody>();
        col = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        vel = mRg.velocity.magnitude;
        if (vel > 18f)
        {
            Color c = new Color(1, 0, 0);
            col.material.color = c;
        }
    }
}
