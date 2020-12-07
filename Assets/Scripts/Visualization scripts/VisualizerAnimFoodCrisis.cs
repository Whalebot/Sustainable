using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualizerAnimFoodCrisis : MonoBehaviour
{
    public string phase;
    public TimeMachine timeMach;
    public bool variableDescends;

    public Animator animatorObj; 
    public bool isCataclysmObj;


    public float limit0;
    public float midLimit12;   

    void Update()
    {
        

        if (isCataclysmObj == true)
        {
            
                if (variableDescends == false) //So, variableAscends to infinity.
                {
                    if(timeMach.hungerCounter >= timeMach.hungerSevereThreshold 
                    && timeMach.hungerCounter <= midLimit12
                    )
                    {
                        animatorObj.SetBool("isCataclysm", true); 
                    }
                    else if(timeMach.hungerCounter < timeMach.hungerSevereThreshold 
                    || timeMach.hungerCounter > midLimit12
                    )
                    {
                        animatorObj.SetBool("isCataclysm", false); 
                    }
                    
                }

                
            

            
        }
       
    }
    
}
