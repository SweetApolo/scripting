using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej3 : MonoBehaviour
{
    Light mluz;
    Light mcolor;

    // Start is called before the first frame update
    void Start()
    {
        mluz = GetComponent<Light>();
        mcolor = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {

        Color r = (Color.red);
        Color a = (Color.blue);
        Color w = (Color.white);
        if (mluz.intensity >= 0.25f || mluz.intensity == 0.5f)
        {
            mcolor.color = a;
        }

        if (mluz.intensity >= 0.5f || mluz.intensity == 0.75f)
        {
            mcolor.color = r;
        }

        if (mluz.intensity >= 0.75f )
        {
            mcolor.color = w;
        }
    }
}
