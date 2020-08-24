using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoEnergy : MonoBehaviour
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
    public TradeOffDescriptorElem req2; //FOR WASTEMA
    public TradeOffDescriptorElem trade1;
    public TradeOffDescriptorElem trade2;
    public TradeOffDescriptorElem trade3; // MONEY

    public bool migrated;


    public void Start()
    {
        counter = 1f;
        //counterThreshold = 5f;
        //sellingPoint = 0f;
        //growthThreshold = 3f;
        timeIsRunning = true;
        StartCoroutine(TimeScheduleCoroutine());
    }

    public void MigratedActivator()
    {
        migrated = true;
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
                    if (migrated == false)
                    {
                        if (money.amountFloat >= req1.tradeFloat)
                        {
                            
                                money.amountFloat -= req1.tradeFloat;
                                energy.amountFloat += trade1.tradeFloat;
                                //wasteManagement.amountFloat -= trade2.tradeFloat;

                                sellingManager.populationGrowthTurns++;
                        
                        }
                    }

                    else if (migrated == true)
                    {
                        if (wasteManagement.amountFloat >= req2.tradeFloat)
                        {
                            
                                money.amountFloat -= trade3.tradeFloat;
                                energy.amountFloat += trade1.tradeFloat;
                                wasteManagement.amountFloat -= req2.tradeFloat;

                                sellingManager.populationGrowthTurns++;
                          

                            //food.amountFloat += trade1.tradeFloat;
                            //energy.amountFloat -= req1.tradeFloat;
                            //pollution.amountFloat += trade2.tradeFloat;

                            //sellingManager.populationGrowthTurns++;


                        }
                    }

                    
                }

            }

        }




    }
}
