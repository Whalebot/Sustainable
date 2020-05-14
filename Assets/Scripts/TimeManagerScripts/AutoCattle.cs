using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCattle : MonoBehaviour
{
    public float counter;
    public float counterThreshold;
    //public float sellingPoint;
    public bool timeIsRunning;
    //public int proof;
    public float populationGrowthTurns;
    public float growthThreshold;

    // RESOURCES REFS
    public Amount food;
    public Amount money;
    public Amount pollution;
    public Amount population;
    public Amount approval;

    public void Start()
    {
        counter = 1f;
        counterThreshold = 10f;
        //sellingPoint = 0f;
        //growthThreshold = 3f;
        timeIsRunning = true;
        StartCoroutine(TimeScheduleCoroutine());
    }

    IEnumerator TimeScheduleCoroutine()
    {
        while (timeIsRunning == true)
        {
            yield return new WaitForSeconds(1);
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

                if (food.amountFloat >= population.amountFloat)
                {
                    food.amountFloat -= population.amountFloat;
                    money.amountFloat += population.amountFloat;
                    pollution.amountFloat += (population.amountFloat / 3f);
                    approval.amountFloat += (population.amountFloat / 5f);

                    populationGrowthTurns++;

                    if (populationGrowthTurns > growthThreshold)
                    {
                        populationGrowthTurns = 0f;
                        growthThreshold *= 1.4f;
                        population.amountFloat += (population.amountFloat *= 1.2f);
                    }


                }

            }

        }




    }
}
