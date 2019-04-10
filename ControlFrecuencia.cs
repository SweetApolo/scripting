using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFrecuencia : MonoBehaviour
{

    Light mLuz;
    AudioSource mAudio;

    // Start is called before the first frame update
    void Start()
    {
        mLuz = GetComponent<Light>();
        mAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mLuz.intensity < 0.5)
        {
            mAudio.pitch = 0.5f;
        }
    }
}
