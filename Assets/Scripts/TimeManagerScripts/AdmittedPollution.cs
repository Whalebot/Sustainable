using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdmittedPollution : MonoBehaviour
{
    public TimeMachine globalTimeManager;
    //public float waitTimeUnit;
    public float counter;
    //public float counterThreshold;
    public bool timeIsRunning;


    // RESOURCES REFS
    //public Amount money;
    public Amount approval;
    public float disapprovalConsequence;
    public Amount naturalCapital;
    public Amount pollution;
    public float startingPollution;
    public float secondPollution;
    public float finalPollution;
    public float thresholdPollution;
    public bool passedThreshold;

    // NOTIFICATION NEWS REFS
    public GameObject arrivingNews;
    public SeenNews worldIcon;
    public GameObject notificationSoundObj;
    public float alertPoints;
    public float alertThreshold;
    public float naturalAlertThreshold;



    //public float moneyMultiplier;
    //public float pollutionDivider;

    //public PopIncreasedPrompter popPrompter;

    public void Start()
    {
        arrivingNews.gameObject.SetActive(false);
        counter = 1f;
        startingPollution = pollution.amountFloat;
        timeIsRunning = true;
        StartCoroutine(TimeScheduleCoroutine());
    }

    IEnumerator TimeScheduleCoroutine()
    {
        while (timeIsRunning == true)
        {
            yield return new WaitForSeconds(globalTimeManager.waitTimeUnit);
            counter++;

            // RESTART OF CYCLE; WHEN counter REACHES counterThreshold RESETS THE COUNTER TO THE BEGINNING OF CYCLE (1f);
            if (counter > globalTimeManager.counterThreshold)
            {
                counter = 1f;
                startingPollution = pollution.amountFloat;
                passedThreshold = false;

            }

            //// "SECONDS" BETWEEN THE START OF CYCLE AND END OF CYCLE;
            //else if (counter < globalTimeManager.counterThreshold)
            //{
            //    finalPollution = (secondPollution - startingPollution);
            //    if (finalPollution > thresholdPollution)
            //    {
            //        passedThreshold = true;
            //    }

            //    else if (finalPollution < thresholdPollution)
            //    {
            //        passedThreshold = false;
            //    }
            //}

            // END OF CYCLE; MAKES FINAL JUDGEMENT OF WHETHER THRESHOLDS WERE MET OR NOT, AND APPLIES CONSEQUENCES OR NOT;
            else if (counter == globalTimeManager.counterThreshold)
            {
                secondPollution = pollution.amountFloat;
                finalPollution = (secondPollution - startingPollution);
                if (finalPollution > thresholdPollution)
                {
                    passedThreshold = true;
                    approval.amountFloat -= disapprovalConsequence;
                    naturalCapital.amountFloat -= disapprovalConsequence /* * 1.2f)*/;

                    alertPoints++;

                    if (alertPoints == alertThreshold)
                    {
                        arrivingNews.gameObject.SetActive(true);
                        worldIcon.ArrivingNotification();
                        notificationSoundObj.gameObject.SetActive(true);
                    }

                    //else if (alertPoints == naturalAlertThreshold)
                    //{

                    //}
                }

                else if (finalPollution < thresholdPollution)
                {
                    passedThreshold = false;
                }
            }

        }




    }
}
