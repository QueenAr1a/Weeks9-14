using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;


public class Hexagon : MonoBehaviour
{
    //Declaring an event which we can then invoke and get other objects to do things
    //When the colour is changed, anything listening to this event will run the corresponding
    //method.
    public UnityEvent onColourChange;

    public TMP_Text counterText;
    private SpriteRenderer hexagonRenderer;

    // Start is called before the first frame update
    void Start()
    {
        hexagonRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnColourizeClick()
    {
        hexagonRenderer.color = Random.ColorHSV();

        //Use Invoke whenever the event is supposed to tell other things to do something.
        //We're changing colour in this method, so everything that's listening to onColourChange
        //is now supposed to do something.
        onColourChange.Invoke();



    }

}

