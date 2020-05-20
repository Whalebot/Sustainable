using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProdButtTutorialer : MonoBehaviour
{
    public int counter;
    //public bool isFood;
    //public bool isEnergy;
    //public bool isWasteM;
    public bool hasFulfilledTutorial;
    //public Tut2 tutManager3;
    //public ArrowActivator tutManag3;
    public Tut2 tutManager4;
    public ArrowActivator tutManag4;

    public void ZContinueTutorial()
    {
        if (hasFulfilledTutorial == false)
        {
            counter++;

            if (counter >= 2)
            {
                tutManager4.Z1SwitchTxt();
                tutManag4.ZDeactivateArrow();

                hasFulfilledTutorial = true;
            }
        }
        
    }

}
