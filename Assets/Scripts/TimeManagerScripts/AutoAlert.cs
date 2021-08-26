using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAlert : MonoBehaviour
{
    public TimeMachine sellingManager;

    //REFS FOR EXCEPTIONS
    public bool isBeeYieldException;

    // UNIVERSAL VARIABLES OR REFS
    public bool alertIsOn;
    public float alertCost;
    public Amount affectedAmount; // Can be money or approval

    public float counter;
    public float counterThreshold;
    public bool timeIsRunning;

    // REFS FOR BEE-YIELD CATACLYSM EXPONENTIAL PUNISHMENTS
    public AmountSimple meatSmallLvl;
    public AmountSimple meatIndusLvl;
    public AmountSimple veggiesSmallLvl;
    public AmountSimple veggiesIndusLvl;
    public AmountSimple insectsSmallLvl;
    public AmountSimple insectsIndusLvl;

    // REFS FOR BEE-YIELD CATACLYSM EXPONENTIAL PUNISHMENTS, FOR tradeFloats FOR HOW MUCH food PRODUCTS GIVE. 
    public TradeOffDescriptorElem meatSmallDescr;
    public TradeOffDescriptorElem meatIndDescr;
    public TradeOffDescriptorElem vegSmallDescr;
    public TradeOffDescriptorElem vegIndDescr;
    public TradeOffDescriptorElem insSmallDescr;
    public TradeOffDescriptorElem insIndDescr;

    // REFS FOR BEE-YIELD CATACLYSM EXPONENTIAL PUNISHMENTS, FOR THE TIME IT TAKES FOR autoCosts TO HAPPEN.
    public AutoCattle meatTimeMachine;
    public AutoCattle vegTimeMachine;
    public AutoCattle insTimeMachine;

    // VARIABLES FOR HOW INTENSELY EACH FOOD TYPE WILL BE AFFECTED BY BEE-YIELD CATACLYSM.
    public float meatRation;
    public float vegRation;
    public float insRation;

    // VARIABLES FOR HOW MUCH FOOD WILL BE SUBTRACTED WHEN BEE-YIELD CATACLYSM HAPPENS.
    public float productChickenSmall;
    public float productChickenIndus;
    public float productVeggSmall;
    public float productVeggIndus;
    public float productInsectSmall;
    public float productInsectIndus;
    public float productsTotal;


    public void Start()
    {
        sellingManager = TimeMachine.Instance;
        counter = 1f;
      
        timeIsRunning = true;
        StartCoroutine(TimeScheduleCoroutine());

        // USED FOR BEE-YIELD CATACLYSM EXPONENTIAL PUNISHMENTS
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
        if (meatSmallLvl.simpleAmount > 0)
        {
            productChickenSmall = ((meatSmallDescr.tradeFloat/meatRation)/meatTimeMachine.counterThreshold)*(counterThreshold);
        }

        if (meatIndusLvl.simpleAmount > 0)
        {
            productChickenIndus = ((meatIndDescr.tradeFloat / meatRation) / (meatTimeMachine.counterThreshold)) * (counterThreshold);

        }

        if (veggiesSmallLvl.simpleAmount > 0)
        {
            productVeggSmall = ((vegSmallDescr.tradeFloat / vegRation) / (vegTimeMachine.counterThreshold)) * (counterThreshold);

        }

        if (veggiesIndusLvl.simpleAmount > 0)
        {
            productVeggIndus = ((vegIndDescr.tradeFloat / vegRation) / (vegTimeMachine.counterThreshold)) * (counterThreshold);

        }

        if (insectsSmallLvl.simpleAmount > 0)
        {
            productInsectSmall = ((insSmallDescr.tradeFloat / insRation) / (insTimeMachine.counterThreshold)) * (counterThreshold);

        }

        if (insectsIndusLvl.simpleAmount > 0)
        {
            productInsectIndus = ((insIndDescr.tradeFloat / insRation) / (insTimeMachine.counterThreshold)) * (counterThreshold);

        }

        // SUM ALL PRODUCTS
        productsTotal = (productChickenSmall + productChickenIndus + productVeggSmall + productVeggIndus + productInsectSmall + productInsectIndus);

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
                //sellingPoint = 0f;
            }
            else if (counter == counterThreshold)
            {
                //sellingPoint++;
                //if (sellingPoint == 1f)
                //{
                //proof++;
                //}
                if (alertIsOn == true)
                {
                    if (isBeeYieldException == false)
                    {
                        affectedAmount.amountFloat -= alertCost;

                    }

                    else if (isBeeYieldException == true)
                    {
                        affectedAmount.amountFloat -= productsTotal;
                    }
                }

            }

        }




    }
}
