using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifgrowing : MonoBehaviour
{
    private float currentTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime < 1)
        {
            currentTime += Time.deltaTime;

        }
        transform.localScale = Vector3.one * currentTime;
    }
}
