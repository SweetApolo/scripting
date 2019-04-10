using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMasa : MonoBehaviour
{

    Rigidbody mMasa;
    Renderer mColor;

    // Start is called before the first frame update
    void Start()
    {
        mMasa = GetComponent<Rigidbody>();
        mColor = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Color r = (Color.red);
        if (mMasa.mass >= 5)
        {
            mColor.material.color = r;
        }
    }
}
