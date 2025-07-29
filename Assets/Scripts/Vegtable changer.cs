using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vegtablechanger : MonoBehaviour
{
    // when we hover over the vegtabel it will beome a broccilie 
    //when we un hover it will be a burger

    public Image foodRenderer;
    public Sprite brocoliSprite, hamburgerSprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnHover()
    {
        foodRenderer.sprite = brocoliSprite;
    }

    public void UnHover()
    {
        foodRenderer.sprite = hamburgerSprite;
    }
}
