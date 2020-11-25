using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualizerParticles : MonoBehaviour
{
    public Amount trackingVariable;
    public bool variableDescends;

    public ParticleSystem partSyst; 
    public bool usesTwoConstants;

    //Particle lifetimes
    public float lifetimePhase1a;
    public float lifetimePhase1b; //Use if usesTwoConstants(true).
    public float lifetimePhase2a;
    public float lifetimePhase2b; //Use if usesTwoConstants(true).
    public float lifetimePhase3a;
    public float lifetimePhase3b; //Use if usesTwoConstants(true).

    public bool isPhase1;
    public bool isPhase2;
    public bool isPhase3; //Uses both midLimit23 and limit3 if variableDescends(true).

    public float limit0; //Always make it a huge negative value.
    public float midLimit12;
    public float midLimit23; //Is top limit (which goes to inifinity) if variableDescends(false).
    public float limit3; //IGNORE if Phase3 goes to infinity and variableDescends(false).

    // void Start()
    // {
    //     ParticleSystem.MainModule psmain = particleSystem.main;
    // }

    void Update()
    {
        ParticleSystem.MainModule psmain = partSyst.main;

        if (usesTwoConstants == true)
        {
            if (variableDescends == false) //So, variableAscends to infinity.
            {
                if(trackingVariable.amountFloat >= limit0 
                && trackingVariable.amountFloat <= midLimit12)
                {
                    psmain.startLifetime = new ParticleSystem.MinMaxCurve (lifetimePhase1a,lifetimePhase1b); 
                }
                else if(trackingVariable.amountFloat > midLimit12 
                && trackingVariable.amountFloat <= midLimit23)
                {
                    psmain.startLifetime = new ParticleSystem.MinMaxCurve (lifetimePhase2a,lifetimePhase2b); 
                }
                else if(trackingVariable.amountFloat > midLimit23)
                {
                    psmain.startLifetime = new ParticleSystem.MinMaxCurve (lifetimePhase3a,lifetimePhase3b); 
                }
            }

            else if (variableDescends == true) //So, variableDescends.
            {
                if(trackingVariable.amountFloat <= limit0 
                && trackingVariable.amountFloat >= midLimit12)
                {
                    psmain.startLifetime = new ParticleSystem.MinMaxCurve (lifetimePhase1a,lifetimePhase1b); 
                }
                else if(trackingVariable.amountFloat < midLimit12 
                && trackingVariable.amountFloat >= midLimit23)
                {
                    psmain.startLifetime = new ParticleSystem.MinMaxCurve (lifetimePhase2a,lifetimePhase2b); 
                }
                else if(trackingVariable.amountFloat < midLimit23
                && trackingVariable.amountFloat >= limit3)
                {
                    psmain.startLifetime = new ParticleSystem.MinMaxCurve (lifetimePhase3a,lifetimePhase3b); 
                }
            }
        }

        else if (usesTwoConstants == false)
        {
            if (variableDescends == false) //So, variableAscends to infinity.
            {
                if(trackingVariable.amountFloat >= limit0 
                && trackingVariable.amountFloat <= midLimit12)
                {
                    psmain.startLifetime = lifetimePhase1a; 
                }
                else if(trackingVariable.amountFloat > midLimit12 
                && trackingVariable.amountFloat <= midLimit23)
                {
                    psmain.startLifetime = lifetimePhase2a; 
                }
                else if(trackingVariable.amountFloat > midLimit23)
                {
                    psmain.startLifetime = lifetimePhase3a; 
                }
            }

            else if (variableDescends == true) //So, variableDescends.
            {
                if(trackingVariable.amountFloat <= limit0 
                && trackingVariable.amountFloat >= midLimit12)
                {
                    psmain.startLifetime = lifetimePhase1a; 
                }
                else if(trackingVariable.amountFloat < midLimit12 
                && trackingVariable.amountFloat >= midLimit23)
                {
                    psmain.startLifetime = lifetimePhase2a; 
                }
                else if(trackingVariable.amountFloat < midLimit23
                && trackingVariable.amountFloat >= limit3)
                {
                    psmain.startLifetime = lifetimePhase3a; 
                }
            }
        }
       
    }
}
