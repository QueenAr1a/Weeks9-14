using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : formanimal
{
    public enum Form
    {
        egg, tadpole, frog
    }
    public Form currentForm = Form.egg;
    public Gradient tadpoleGradient;
    public Gradient frogGradient;

    private ParticleSystem frogParticles;
    private ParticleSystem.MainModule frogModule;

    private void Awake()
    {
        frogParticles = GetComponent<ParticleSystem>();
        frogModule = frogParticles.main;
    }

    // Update is called once per frame
    void Update()
    {
        FormUpdate();
    }

    public override void ChangeForm()
    {
        if (currentForm == Form.egg)
        {
            timeInForm = 0f;
            currentForm = Form.tadpole;
            Debug.Log("Changing form to Tadpole");

            frogModule.startColor = tadpoleGradient;
        }
        else if (currentForm == Form.tadpole)
        {
            timeInForm = 0f;
            currentForm = Form.frog;
            Debug.Log("Changing form to Frog");
            frogModule.startColor = frogGradient;
        }
    }
}




