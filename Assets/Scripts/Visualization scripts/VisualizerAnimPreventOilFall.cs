using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualizerAnimPreventOilFall : MonoBehaviour
{
    public string phase;
    public Amount trackingVariable;
    public AmountSimple upgradePlusTrackingVariable;
    public AutoAlert timeManagerAlerter; //Use only if cataclysm has a sourceAffector and a targetVariable
    public CattleSmallCatac fossilNews;
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
        

        if (isCataclysmObj == true) // THIS IS NOT A VARIABLE (active or passive res.); IT IS A CATAC.
        {
            

            if (cataclysmUsesUpgradeSimpleAmount == true)
            {
                if (fossilNews.biogasIsActivated == false)
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
                }

                else if (fossilNews.biogasIsActivated == true)
                {
                    if (variableDescends == false) //So, variableAscends to infinity.
                    {
                        if(upgradePlusTrackingVariable.simpleAmount >= limit0 
                        && upgradePlusTrackingVariable.simpleAmount <= midLimit12)
                        {
                            animatorObj.SetBool("isCataclysm", false); 
                        }
                        else if(upgradePlusTrackingVariable.simpleAmount < limit0 
                        && upgradePlusTrackingVariable.simpleAmount > midLimit12)
                        {
                            animatorObj.SetBool("isCataclysm", false); 
                        }
                        
                    }
                } 
                

                
            }
        }
       
    }
    
}
