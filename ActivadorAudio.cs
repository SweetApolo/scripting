using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorAudio : MonoBehaviour
{
    AudioSource mAudio;
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        mAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

            if (t >= 5)
            {
              mAudio.volume = 0;
            }
    }
}
