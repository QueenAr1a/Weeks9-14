using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Hexagoncounter : MonoBehaviour
{
    public TMP_Text counterText;
    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //This method is called via the event every time we change the colour of any hexagon
    public void IncreaseCount()
    {
        //We increase the counter which is tracked locally on this script
        counter++;

        //Update the text counter to match up with the new count
        counterText.text = counter.ToString();
    }

}
