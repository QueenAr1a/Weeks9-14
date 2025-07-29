using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hexagoncolorizer : MonoBehaviour
{
    public SpriteRenderer hexagonRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnColourizeClick()
    {
        hexagonRenderer.color = Random.ColorHSV();
    }
}
