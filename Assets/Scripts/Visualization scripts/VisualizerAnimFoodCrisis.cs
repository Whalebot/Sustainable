using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualizerAnimFoodCrisis : MonoBehaviour
{
    public string phase;
    public TimeMachine sellingManager;
    public bool variableDescends;

    public Animator animatorObj; 
    public bool isCataclysmObj;


    public float limit0;
    public float midLimit12;

    private void Start()
    {
        sellingManager = TimeMachine.Instance;
    }

    void Update()
    {
        

        if (isCataclysmObj == true)
        {
            
                if (variableDescends == false) //So, variableAscends to infinity.
                {
                    if(sellingManager.hungerCounter >= sellingManager.hungerSevereThreshold 
                    && sellingManager.hungerCounter <= midLimit12
                    )
                    {
                        animatorObj.SetBool("isCataclysm", true); 
                    }
                    else if(sellingManager.hungerCounter < sellingManager.hungerSevereThreshold 
                    || sellingManager.hungerCounter > midLimit12
                    )
                    {
                        animatorObj.SetBool("isCataclysm", false); 
                    }
                    
                }

                
            

            
        }
       
    }
    
}
