using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour
{

    Renderer mcolor;
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        mcolor = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        Color r = (Color.red);
        Color a = (Color.blue);
        Color m = (Color.red + Color.blue);
        mcolor.material.color = r;
        if (t <= 3)
        {
            mcolor.material.color = r;
        }

        if (t > 3 || t == 6)
        {
            mcolor.material.color = a;
        }

        if (t >= 6)
        {
            mcolor.material.color = m;
        }

    }
}
