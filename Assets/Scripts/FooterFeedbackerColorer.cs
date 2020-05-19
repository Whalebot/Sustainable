using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FooterFeedbackerColorer : MonoBehaviour
{
    public AutoAlert autoAlert;
    public CattleSmallCatac catacNewsObj;

    public Image lightObj;
    public Image normalObj;
    public Image darkObj;

    public Color originalLight;
    public Color originalNormal;
    public Color originalDark;
    public Color alertLight;
    public Color alertNormal;
    public Color alertDark;

    public Amount footerAmount;

    public DarkOceanBlender oceanThreshold;
    public bool usesPollution;
    public float threshold;
    public float middleThreshold;
    public bool usesLessThan;
    public bool usesMoreThan;

    public void Start()
    {
        lightObj.color = originalLight;
        normalObj.color = originalNormal;
        darkObj.color = originalDark;

        if(usesPollution == true)
        {
            threshold = oceanThreshold.threshold; // THIS IS WHY YOU CONTROL THE THRESHOLD FROM THE OCEAN.

        }
    }

    public void Update()
    {
        catacNewsObj.CheckThresholds();

        if (usesLessThan == true)
        {
            if (footerAmount.amountFloat <= threshold) // ALERT IS ON
            {
                //lightObj.color = alertLight;
                normalObj.color = alertNormal;
                //darkObj.color = alertDark;

                autoAlert.alertIsOn = true;

            }

            else if (footerAmount.amountFloat > threshold) // ALERT IS OFF
            {
                //lightObj.color = originalLight;
                normalObj.color = originalNormal;
                //darkObj.color = originalDark;

                autoAlert.alertIsOn = false;

             
            }
        }

        else if (usesMoreThan == true)
        {
            if (footerAmount.amountFloat >= threshold) // ALERT IS ON
            {
                //lightObj.color = alertLight;
                normalObj.color = alertNormal;
                //darkObj.color = alertDark;

                autoAlert.alertIsOn = true;

            }

            else if (footerAmount.amountFloat < threshold) // ALERT IS OFF
            {
                //lightObj.color = originalLight;
                normalObj.color = originalNormal;
                //darkObj.color = originalDark;

                autoAlert.alertIsOn = false;

            }
        }
        
    }
}
