using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoWasteM : MonoBehaviour
{
    public TimeMachine sellingManager;

    public float counter;
    public float counterThreshold;
    //public float sellingPoint;
    public bool timeIsRunning;
    //public int proof;
    public float populationGrowthTurns;
    public float growthThreshold;

    // RESOURCES REFS
    public AmountSimple boughtInfrasctructure;
    public Amount food;
    public Amount energy;
    public Amount wasteManagement;
    public Amount money;
    public Amount pollution;
    public Amount population;
    public Amount approval;

    // REQUIREMENT REFS
    public TradeOffDescriptorElem req1; //ONLY REQUIRES ENERGY, I THINK...
    public TradeOffDescriptorElem trade1Money;
    public TradeOffDescriptorElem trade2WasteM;
    public TradeOffDescriptorElem trade3Pollut;
    public TradeOffDescriptorElem trade4Approv;



    public void Start()
    {
        counter = 1f;
        //counterThreshold = 5f;
        //sellingPoint = 0f;
        //growthThreshold = 3f;
        timeIsRunning = true;
        StartCoroutine(TimeScheduleCoroutine());
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
                if (boughtInfrasctructure.simpleAmount > 0)
                {
                    if (energy.amountFloat >= req1.tradeFloat)
                    {
                        energy.amountFloat -= req1.tradeFloat;
                        money.amountFloat += trade1Money.tradeFloat;
                        wasteManagement.amountFloat += trade2WasteM.tradeFloat;
                        pollution.amountFloat -= trade3Pollut.tradeFloat;
                        approval.amountFloat += trade4Approv.tradeFloat;



                        sellingManager.populationGrowthTurns++;


                    }
                }

            }

        }




    }
}
