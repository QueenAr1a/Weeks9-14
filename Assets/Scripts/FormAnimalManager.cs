using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormAnimalManager : MonoBehaviour
{
    public List<formanimal> formAnimals;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < formAnimals.Count; i++)
        {
            formAnimals[i].ChangeForm();
            formAnimals[i].ChangeForm();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

