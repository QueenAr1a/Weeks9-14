using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sniw : MonoBehaviour
{
    public ParticleSystem snow;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            togglesnow();
        }
    }

    void togglesnow()
    {
        if(snow.isPlaying)
        {
            snow.Stop();
        }
        if (snow.isStopped)
        {
            snow.Play();
        }
    }

}
