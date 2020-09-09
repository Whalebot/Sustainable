using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resource : MonoBehaviour
{
    public Amount resourceCurrent; // Has data about current resource status.
    //public float milePrev;
    //public Amount mileCurrent;
    //public float mileExponent;
    //public Amount lvlCurrent;
    //public Image lvlLiquid;
    //public Image universalLiquid;

    //LeanTween animation references.
    //public SparkAnimator sparkAnimator;
    //public LevelTxtAnimator lvlTextAnimator;

    //public void FillLiquid()
    //{
    //    Lines for Current Lvl Liquid Progress.
    //    float globalDifference = /*(mileCurrent.amountFloat - milePrev)*/;
    //    float localDifference = /*(resourceCurrent.amountFloat - milePrev)*/;
    //    float percent = (localDifference / globalDifference);
    //    lvlLiquid.fillAmount = percent;

    //    Lines for Universal Liquid Progress.
    //    float universalPercent = (resourceCurrent.amountFloat / mileCurrent.amountFloat);
    //    Debug.Log(universalPercent);
    //    universalLiquid.fillAmount = universalPercent;

    //    if (resourceCurrent.amountFloat >= mileCurrent.amountFloat)
    //    {
    //        LvlUp();
    //    }
    //}

    //public void LvlUp()
    //{
    //    lvlCurrent.onlyLvl++;
    //    milePrev = mileCurrent.amountFloat;
    //    mileCurrent.amountFloat *= mileExponent;
    //    //sparkAnimator.LvlUpSparker();
    //    //lvlTextAnimator.LvlUpBlinker();
    //}

    public void Update()
    {
        //FillLiquid();

        resourceCurrent.amountTxt.text = resourceCurrent.amountFloat.ToString("0.0"); //Updates Resource amount.
        if (resourceCurrent.amountFloat < 0f)
        {
            resourceCurrent.amountFloat = 0f;
        }
        //lvlCurrent.amountTxt.text = "Level " + lvlCurrent.onlyLvl; //Updates Level number.
        //mileCurrent.amountTxt.text = "Milestone: " + mileCurrent.amountFloat.ToString("0");

    }

}
