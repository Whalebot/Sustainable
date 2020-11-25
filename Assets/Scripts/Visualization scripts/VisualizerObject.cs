using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualizerObject : MonoBehaviour
{
    public Amount trackingVariable;
    public bool variableDescends;

    public GameObject phase01;
    public GameObject phase02;
    public GameObject phase03;

    public bool isPhase1;
    public bool isPhase2;
    public bool isPhase3; //Uses both midLimit23 and limit3 if variableDescends(true).

    public float limit0; //Always make it a huge negative value.
    public float midLimit12;
    public float midLimit23; //Is top limit (which goes to inifinity) if variableDescends(false).
    public float limit3; //IGNORE if Phase3 goes to infinity and variableDescends(false).

    void Update()
    {
        if (variableDescends == false) //So, variableAscends to infinity.
        {
            if(trackingVariable.amountFloat >= limit0 
            && trackingVariable.amountFloat <= midLimit12)
            {
                phase01.SetActive(true);
                phase02.SetActive(false);
                phase03.SetActive(false);

            }
            else if(trackingVariable.amountFloat > midLimit12 
            && trackingVariable.amountFloat <= midLimit23)
            {
                phase01.SetActive(true);
                phase02.SetActive(true);
                phase03.SetActive(false);            
            }
            else if(trackingVariable.amountFloat > midLimit23)
            {
                phase01.SetActive(true);
                phase02.SetActive(true);
                phase03.SetActive(true);            
            }
        }

        else if (variableDescends == true) //So, variableDescends.
        {
            if(trackingVariable.amountFloat <= limit0 
            && trackingVariable.amountFloat >= midLimit12)
            {
                phase01.SetActive(true);
                phase02.SetActive(false);
                phase03.SetActive(false);            }
            else if(trackingVariable.amountFloat < midLimit12 
            && trackingVariable.amountFloat >= midLimit23)
            {
                phase01.SetActive(true);
                phase02.SetActive(true);
                phase03.SetActive(false);            
            }
            else if(trackingVariable.amountFloat < midLimit23
            && trackingVariable.amountFloat >= limit3)
            {
                phase01.SetActive(true);
                phase02.SetActive(true);
                phase03.SetActive(true);            
            }
        }
    }
}
