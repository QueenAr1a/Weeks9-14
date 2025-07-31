using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class scripttree : MonoBehaviour
{
    public AnimationCurve tree;
    public List <Transform> appleTransforms;
    private float currentTime = 0f;

    public float duration;
    //bool hasBeenClicked = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Once we've clicked the button, we can start growing and calling this logic
        //if no coroutine
       // if (hasBeenClicked == true)
       // {
       //     StartCoroutine(Grow());
            
      //  }
    }
    //Called from our button click
    public void StartGrow()
    {
        //Reset the current time 
        currentTime = 0f;
        //Let this script know that the button has been pressed
        // hasBeenClicked = true;
        //instead with courotines you can just use the start 
        StartCoroutine(Grow());
    }
    //Adding IEnumerator as the return type
    //Sets the method to be a Coroutine method
    public IEnumerator Grow()
    {
      ;

        while (currentTime < duration)
        { 
        currentTime += Time.deltaTime;
            //We need to return something to satisfy IEnumerator as the return value
            //This is the syntax for doing so
            float timeRatio = currentTime / duration;

            transform.localScale = Vector3.one * tree.Evaluate(timeRatio);
            //We need to return something to satisfy IEnumerator as the return value
            //This is the syntax for doing so

            //yield return null will relinquish control to everything else
            //for the rest of this frame so that the Coroutine doesn't hold Unity
            //hostage
            yield return null;
        }
        //if (isgrow)
        //{
         //   currentTime += Time.deltaTime;
          //  yield return null;
       // }
        //else
        //{
       //     hasBeenClicked = false;
           
        //}

        //We use the time ratio so that it takes the duration to get from the start
        //to the end when we use the animation curve
        //(or something like a Lerp)

     

        //yield return null;

    


        currentTime = 0;
        int i = 0;
        while (currentTime < duration && i < appleTransforms.Count)
        {
            currentTime += Time.deltaTime;
            //We need to return something to satisfy IEnumerator as the return value
            //This is the syntax for doing so
            float timeRatio = currentTime / duration;

            appleTransforms[i].localScale = Vector3.one * tree.Evaluate(timeRatio);

            if (currentTime>= duration)
            {
                i++;
                currentTime = 0;
            }
            yield return null;
        }
        //if (isgrow)
        //{
        //   currentTime += Time.deltaTime;
        //  yield return null;
        // }
        //else
        //{
        //     hasBeenClicked = false;

        //}

        //We use the time ratio so that it takes the duration to get from the start
        //to the end when we use the animation curve
        //(or something like a Lerp)

    

        //appleTransform.localScale = Vector3.one * tree.Evaluate(timeRatio);

        //yield return null;

        //Coroutines are really really really nice when you want to run things in 
        //a sequence one after the other

    }
}
