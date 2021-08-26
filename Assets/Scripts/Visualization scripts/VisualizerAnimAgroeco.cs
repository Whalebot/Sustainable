using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualizerAnimAgroeco : MonoBehaviour
{
    public string phase;
    public Amount trackingVariable;
    public AmountSimple upgradePlusTrackingVariable;
    public AutoAlert TimeMachineAlerter; //Use only if cataclysm has a sourceAffector and a targetVariable
    public AutoAgroecology agroecologyTimeMachine;
    public bool variableDescends;

    public Animator animatorObj; 
    public bool isCataclysmObj;
    public bool cataclysmUsesUpgradeSimpleAmount;
    public bool isSmallFoodType;
    public bool isInustrialFoodType;
    public Amount foodTypeAmount;
    public AmountSimple plusInustrialUpgrade;


    public float limit0;
    public float midLimit12;   

    void Update()
    {
        if (isCataclysmObj == false) // THIS IS A VARIABLE: either Active resource or Passive resource.

        {
            
            if (isSmallFoodType == true) // THIS IS Smallscale FOOD.
            {
                if (variableDescends == false) //So, variableAscends to infinity.
                {
                    if(trackingVariable.amountFloat >= limit0 
                    && trackingVariable.amountFloat <= midLimit12)
                    {
                        if (foodTypeAmount.amountFloat > 0)
                        {
                            if (agroecologyTimeMachine.timeIsRunning == true)
                            {
                                animatorObj.SetBool("isOn", true); 
                            }
                        }
                    }
                    else if(trackingVariable.amountFloat < limit0 
                    || trackingVariable.amountFloat > midLimit12)
                    {
                        animatorObj.SetBool("isOn", false); 
                    }
                    
                }

                
            }

            
            
        }

        
       
    }
    
}
