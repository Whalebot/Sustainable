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
            if (isSmallFoodType == false && isInustrialFoodType == false) // THIS IS NOT ANY FOOD.
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

                else if (variableDescends == true) //So, variableDescends. It's probably NatCap or Bees.
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

            else if (isSmallFoodType == true) // THIS IS Smallscale FOOD.
            {
                if (variableDescends == false) //So, variableAscends to infinity.
                {
                    if(trackingVariable.amountFloat >= limit0 
                    && trackingVariable.amountFloat <= midLimit12)
                    {
                        if (foodTypeAmount.amountFloat > 0)
                        {
                            animatorObj.SetBool("isOn", true); 
                        }
                    }
                    else if(trackingVariable.amountFloat < limit0 
                    || trackingVariable.amountFloat > midLimit12)
                    {
                        animatorObj.SetBool("isOn", false); 
                    }
                    
                }

                // else if (variableDescends == true) //So, variableDescends. It's probably NatCap or Bees.
                // {
                //     if(trackingVariable.amountFloat <= limit0 
                //     && trackingVariable.amountFloat >= midLimit12)
                //     {
                //         animatorObj.SetBool("isOn", true); 
                //     }
                //     else if(trackingVariable.amountFloat > limit0 
                //     || trackingVariable.amountFloat < midLimit12)
                //     {
                //         animatorObj.SetBool("isOn", false); 
                //     }
                    
                // }
            }

            else if (isInustrialFoodType == true) // THIS IS Industrial FOOD.
            {
                if (variableDescends == false) //So, variableAscends to infinity.
                {
                    if(trackingVariable.amountFloat >= limit0 
                    && trackingVariable.amountFloat <= midLimit12)
                    {
                        if (plusInustrialUpgrade.simpleAmount > 0)
                        {
                            animatorObj.SetBool("isOn", true); 
                        }
                    }
                    else if(trackingVariable.amountFloat < limit0 
                    || trackingVariable.amountFloat > midLimit12)
                    {
                        animatorObj.SetBool("isOn", false); 
                    }
                    
                }

                // else if (variableDescends == true) //So, variableDescends. It's probably NatCap or Bees.
                // {
                //     if(trackingVariable.amountFloat <= limit0 
                //     && trackingVariable.amountFloat >= midLimit12)
                //     {
                //         animatorObj.SetBool("isOn", true); 
                //     }
                //     else if(trackingVariable.amountFloat > limit0 
                //     || trackingVariable.amountFloat < midLimit12)
                //     {
                //         animatorObj.SetBool("isOn", false); 
                //     }
                    
                // }
            }
            
        }

        else if (isCataclysmObj == true) // THIS IS NOT A VARIABLE (active or passive res.); IT IS A CATAC.
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
