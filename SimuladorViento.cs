using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimuladorViento : MonoBehaviour
{

    Rigidbody mRg;
    // Start is called before the first frame update
    void Start()
    {
        mRg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Pluma")
        {
            mRg.drag = 10;
        }

        if (gameObject.tag == "Ladrillo")
        {
            mRg.drag = 0;
        }

        if (gameObject.tag == "Papel")
        {
            mRg.drag = 5;
        }

    }
}
