using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMat : MonoBehaviour
{
        public float speed = 3;
 
    public GameObject Mat;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(moveMat());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator moveMat()
    {
        while (true)
        {

            Mat.transform.position += Vector3.right * speed * Time.deltaTime;
            Vector3 matinScreen = Camera.main.WorldToScreenPoint(transform.position);
            if (matinScreen.x >= Screen.width / 2)
            {
                speed = 0f;
                yield break;
            }

            yield return null;

        }
    }
}
