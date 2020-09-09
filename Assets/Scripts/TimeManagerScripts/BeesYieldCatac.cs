using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeesYieldCatac : MonoBehaviour
{
    public TimeMachine sellingManager;

    public bool alertIsOn;
    public float alertCost;
    public Amount affectedAmount; // Can be money or approval or Food
    public AmountSimple chickenbeefSmallLvl;
    public AmountSimple chickenbeefIndusLvl;
    public AmountSimple veggiesSmallLvl;
    public AmountSimple veggiesIndusLvl;
    public AmountSimple insectsSmallLvl;
    public AmountSimple insectsIndusLvl;


    public float counter;
    public float counterThreshold;
    public bool timeIsRunning;

    // REFS FOR EXPONENTIAL PUNISHMENTS
    public float numberChickenSmall;
    public float numberChickenIndus;
    public float numberVeggSmall;
    public float numberVeggIndus;
    public float numberInsectSmall;
    public float numberInsectIndus;

    public float productChickenSmall;
    public float productChickenIndus;
    public float productVeggSmall;
    public float productVeggIndus;
    public float productInsectSmall;
    public float productInsectIndus;



    public void Start()
    {
        counter = 1f;
        timeIsRunning = true;
        StartCoroutine(TimeScheduleCoroutine());

        productChickenSmall = 0f;
        productChickenIndus = 0f;
        productVeggSmall = 0f;
        productVeggIndus = 0f;
        productInsectSmall = 0f;
        productInsectIndus = 0f;
}

    // WILL BE CALLED USING AutoUpg/AutoUpgrade PLUS BUTTON.
    public void CalculateBeeYieldPunishment()
    {
        if (chickenbeefSmallLvl.simpleAmount > 0)
        {
            productChickenSmall = Mathf.Pow(numberChickenSmall, chickenbeefSmallLvl.simpleAmount);
        }

        if (chickenbeefIndusLvl.simpleAmount > 0)
        {
            productChickenIndus = Mathf.Pow(numberChickenIndus, chickenbeefIndusLvl.simpleAmount);

        }

        if (veggiesSmallLvl.simpleAmount > 0)
        {
            productVeggSmall = Mathf.Pow(numberVeggSmall, veggiesSmallLvl.simpleAmount);

        }

        if (veggiesIndusLvl.simpleAmount > 0)
        {
            productVeggIndus = Mathf.Pow(numberVeggIndus, veggiesIndusLvl.simpleAmount);

        }

        if (insectsSmallLvl.simpleAmount > 0)
        {
            productInsectSmall = Mathf.Pow(numberInsectSmall, insectsSmallLvl.simpleAmount);

        }

        if (insectsIndusLvl.simpleAmount > 0)
        {
            productInsectIndus = Mathf.Pow(numberInsectIndus, insectsIndusLvl.simpleAmount);

        }

    }

    IEnumerator TimeScheduleCoroutine()
    {
        while (timeIsRunning == true)
        {
            yield return new WaitForSeconds(sellingManager.waitTimeUnit);
            counter++;

            if (counter > counterThreshold)
            {
                counter = 1f;
            }
            else if (counter == counterThreshold)
            {
                if (alertIsOn == true)
                {
                    affectedAmount.amountFloat -= alertCost;
                }

            }

        }




    }

}
