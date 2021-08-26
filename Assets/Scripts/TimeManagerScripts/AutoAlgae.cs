﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAlgae : MonoBehaviour
{
    public TimeMachine sellingManager;

    public float counter;
    public float counterThreshold;
    //public float sellingPoint;
    public bool timeIsRunning;
    //public int proof;
    public float populationGrowthTurns;
    public float growthThreshold;

    public bool usesCataclysm;

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
    public TradeOffDescriptorElem trade1;
    public TradeOffDescriptorElem trade2;


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
                        if (usesCataclysm == false)
                        {
                            food.amountFloat += trade1.tradeFloat;
                            energy.amountFloat -= req1.tradeFloat;
                            pollution.amountFloat -= trade2.tradeFloat;

                            //sellingManager.populationGrowthTurns++;

                        }

                        else if (usesCataclysm == true)
                        {
                            food.amountFloat += trade1.tradeFloat;
                            energy.amountFloat -= req1.tradeFloat;
                            pollution.amountFloat += trade2.tradeFloat;

                            //sellingManager.populationGrowthTurns++;
                        }


                    }
                }

            }

        }




    }
}
