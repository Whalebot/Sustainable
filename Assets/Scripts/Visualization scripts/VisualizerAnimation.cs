using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualizerAnimation : MonoBehaviour
{
    public string phase;
    public Amount trackingVariable;
    public AmountSimple upgradePlusTrackingVariable;
    public AutoAlert timeManagerAlerter; //Use only if cataclysm has a sourceAffector and a targetVariable
    public bool variableDescends;

    public Animator animatorObj; 
    public bool isCataclysmObj;
    public bool cataclysmUsesUpgradeSimpleAmount;


    public float limit0;
    public float midLimit12;   

    void Update()
    {
        if (isCataclysmObj == false)
        {
            if (variableDescends == false) //So, variableAscends to infinity.
            {
                if(trackingVariable.amountFloat >= limit0 
                && trackingVariable.amountFloat <= midLimit12)
                {
                    animatorObj.SetBool("isOn", true); 
                }
                else if(trackingVariable.amountFloat < limit0 
                || trackingVariable.amountFloat > midLimit12)
                {
                    animatorObj.SetBool("isOn", false); 
                }
                
            }

            else if (variableDescends == true) //So, variableDescends.
            {
                if(trackingVariable.amountFloat <= limit0 
                && trackingVariable.amountFloat >= midLimit12)
                {
                    animatorObj.SetBool("isOn", true); 
                }
                else if(trackingVariable.amountFloat > limit0 
                || trackingVariable.amountFloat < midLimit12)
                {
                    animatorObj.SetBool("isOn", false); 
                }
                
            }
        }

        else if (isCataclysmObj == true)
        {
            if (cataclysmUsesUpgradeSimpleAmount == false)
            {

                if (variableDescends == false) //So, variableAscends to infinity.
                {
                    if(trackingVariable.amountFloat >= limit0 
                    && trackingVariable.amountFloat <= midLimit12
                    && timeManagerAlerter.alertIsOn == true)
                    {
                        animatorObj.SetBool("isCataclysm", true); 
                    }
                    else if(/*trackingVariable.amountFloat < limit0*/ 
                    // || trackingVariable.amountFloat > midLimit12
                    /*&&*/ timeManagerAlerter.alertIsOn == false)
                    {
                        animatorObj.SetBool("isCataclysm", false); 
                    }
                    
                }

                else if (variableDescends == true) //So, variableDescends.
                {
                    if(trackingVariable.amountFloat <= limit0 
                    && trackingVariable.amountFloat >= midLimit12
                    && timeManagerAlerter.alertIsOn == true)
                    {
                        animatorObj.SetBool("isCataclysm", true); 
                    }
                    else if(/*trackingVariable.amountFloat > limit0 
                    && trackingVariable.amountFloat < midLimit12*/
                    timeManagerAlerter.alertIsOn == false)
                    {
                        animatorObj.SetBool("isCataclysm", false); 
                    }
                    
                }
            }

            else if (cataclysmUsesUpgradeSimpleAmount == true)
            {

                if (variableDescends == false) //So, variableAscends to infinity.
                {
                    if(upgradePlusTrackingVariable.simpleAmount >= limit0 
                    && upgradePlusTrackingVariable.simpleAmount <= midLimit12)
                    {
                        animatorObj.SetBool("isCataclysm", true); 
                    }
                    else if(upgradePlusTrackingVariable.simpleAmount < limit0 
                    && upgradePlusTrackingVariable.simpleAmount > midLimit12)
                    {
                        animatorObj.SetBool("isCataclysm", false); 
                    }
                    
                }

                else if (variableDescends == true) //So, variableDescends.
                {
                    if(upgradePlusTrackingVariable.simpleAmount <= limit0 
                    && upgradePlusTrackingVariable.simpleAmount >= midLimit12)
                    {
                        animatorObj.SetBool("isCataclysm", true); 
                    }
                    else if(upgradePlusTrackingVariable.simpleAmount > limit0 
                    && upgradePlusTrackingVariable.simpleAmount < midLimit12)
                    {
                        animatorObj.SetBool("isCataclysm", false); 
                    }
                    
                }
            }
        }
       
    }
    
}
