using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFreeEnergy : MonoBehaviour
{
    public float waitTimeUnit;
    public float counter;
    public float counterThreshold;
    //public float sellingPoint;
    public bool timeIsRunning;
    //public int proof;


    // RESOURCES REFS
    public Amount ener;
    public float freeEner;

    public void Start()
    {
        counter = 1f;
        //sellingPoint = 0f;
        //growthThreshold = 3f;
        timeIsRunning = true;
        StartCoroutine(TimeScheduleCoroutine());
    }

    IEnumerator TimeScheduleCoroutine()
    {
        while (timeIsRunning == true)
        {
            yield return new WaitForSeconds(waitTimeUnit);
            counter++;

            if (counter > counterThreshold)
            {
                counter = 1f;
                //sellingPoint = 0f;
            }
            else if (counter == counterThreshold)
            {
                ener.amountFloat += freeEner;

                

            }

        }




    }
}
