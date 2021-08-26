using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAgroecology : MonoBehaviour
{
    public TimeMachine sellingManager;

    public float counter;
    public float counterThreshold;
    //public float sellingPoint;
    public bool timeIsRunning;
    //public int proof;
    //public float populationGrowthTurns;
    //public float growthThreshold;

    // RESOURCES REFS
    //public AmountSimple boughtInfrasctructure;
    public Amount food;
    public Amount energy;
    public Amount wasteManagement;
    public Amount money;
    public Amount pollution;
    public Amount population;
    public Amount approval;

    // REQUIREMENT REFS (FOOD AND POLLUTION descriptorElems)
    //public TradeOffDescriptorElem req1; //ONLY REQUIRES ENERGY, I THINK...
    public TradeOffDescriptorElem foodtypeSmallFoodDescr;
    public TradeOffDescriptorElem foodtypeSmallPollutionDescr;
    public float bonusFood;
    public float bonusRemovedPollution;

    // VARIABLES FOR RATIO OF HOW MUCH FOOD/POLLUTION IS AFFECTED
    public float bonusFoodMultiplier;
    public float bonusRemovedPollutMultiplier;


    public void Start()
    {
        sellingManager = TimeMachine.Instance;
        bonusFood = (foodtypeSmallFoodDescr.tradeFloat * bonusFoodMultiplier);
        bonusRemovedPollution = (foodtypeSmallPollutionDescr.tradeFloat * bonusRemovedPollutMultiplier);
        counter = 1f;
        //counterThreshold = 5f;
        //sellingPoint = 0f;
        //growthThreshold = 3f;
        timeIsRunning = false;
    }

    public void ActivateAgroecology()
    {
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

                bonusFood = (foodtypeSmallFoodDescr.tradeFloat * bonusFoodMultiplier);
                bonusRemovedPollution = (foodtypeSmallPollutionDescr.tradeFloat * bonusRemovedPollutMultiplier);

                food.amountFloat += bonusFood;
                pollution.amountFloat -= bonusRemovedPollution;


            }

        }




    }
}
