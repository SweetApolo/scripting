using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej4 : MonoBehaviour
{

    Light mluz;
    // Start is called before the first frame update
    void Start()
    {
        mluz = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        mluz.intensity = 0.5f * transform.localScale.magnitude;
    }
}
