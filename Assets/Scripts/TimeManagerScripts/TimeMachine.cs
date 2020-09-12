using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeMachine : MonoBehaviour
{
    public bool timeMatters;

    public bool needsRender;

    public float waitTimeUnit;
    public float counter;
    public float counterThreshold;
    //public float sellingPoint;
    public bool timeIsRunning;
    //public int proof;
    public float populationGrowthTurns;
    public float growthThreshold;

    public AudioSource moneySfx;

    // RESOURCES REFS
    public Amount food;
    public Amount money;
    public Amount pollution;
    public Amount population;
    public Amount approval;

    public float moneyMultiplier;
    public float pollutionDivider;
    public float populationMultiplier;
    public float growthThresholdMultiplier;

    public PopIncreasedPrompter popPrompter;

    // HAPPY/SAD FEEDBACK
    public GameObject happyClock;
    public GameObject sadClock;
    public AudioSource angryCrowdSfx;

    // HUNGER COUNTERS REFS
    public float hungerCounter;
    public float hungerMildThreshold;
    public float hungerSevereThreshold;
    public float maxHungerCounter;
    public bool isAI;

    // NEWS REFS
    public HungerCatac hungerNewsManager;
    //public GameObject arrivingNews;
    //public SeenNews worldIcon;
    //public GameObject notificationSoundObj;

    // CATACLYSM REFS
    public AutoAlert foodCrisisAutoAlert;
    //public GameObject firstCataclysmWindow;
    //public GameObject secondCataclysmWindow;

    public void Start()
    {
        needsRender = false;

        // (timeMatters = false) MAKES PEOPLE NOT GET HUNGRY, WHEN THE GAME STARTS RUNNING,
        // SO PLAYERS CAN HAVE TIME TO PREPARE WITH TUTORIAL OR DURING START SCREEN,
        // BUT ONCE YOU PRESS "Play!" OR "Skip Tutorial", POPULATION CAN GET HUNGRY.
        //timeMatters = false;
        if (FindObjectOfType<SimpleAI>() == null)
        {
            isAI = false;
            happyClock.gameObject.SetActive(false);
            sadClock.gameObject.SetActive(false);
        }
        else
        {
            isAI = true; // COMMENTED THIS LINE BECAUSE sadClock WAS NOT BEING DEACTIVATED ON ITCH BUILD.
            //isAI = false; // UNCOMMENT PREVIOUS LINE AND COMMENT THIS LINE WHEN PUSHING TO GIT. THIS LINE IS ONLY USED FOR ITCH BUILD.
            //happyClock.gameObject.SetActive(false); // COMMENT THIS LINE FOR GIT
            //sadClock.gameObject.SetActive(false); // COMMENT THIS LINE FOR GIT

        }

        counter = 1f;
        //sellingPoint = 0f;
        //growthThreshold = 3f;
        timeIsRunning = true;
        StartCoroutine(TimeScheduleCoroutine());
    }

    public void NeedsRenderActivator()
    {
        needsRender = true;
    }

    // THIS METHOD ENABLES THE HUNGER
    public void PeopleCanGetHungry()
    {
        timeMatters = true;
    }

    //public void CloseCataclysmWindow()
    //{
    //    secondCataclysmWindow.gameObject.SetActive(false);
    //}

    public void Update()
    {
        if (hungerCounter < 0f)
        {
            hungerCounter = 0f;
        }

        else if (hungerCounter > maxHungerCounter)
        {
            hungerCounter = maxHungerCounter;
        }
    }


    IEnumerator TimeScheduleCoroutine()
    {
        

        
        while (timeIsRunning == true)
        {
            yield return new WaitForSeconds(waitTimeUnit);
            counter++;

            if(counter > counterThreshold)
            {
                counter = 1f;
                if (!isAI) // COMMENTED THIS LINE BECAUSE sadClock WAS NOT BEING DEACTIVATED ON ITCH BUILD.
                //if (isAI == false) // UNCOMMENT PREVIOUS LINE AND COMMENT THIS LINE WHEN PUSHING TO GIT. THIS LINE IS ONLY USED FOR ITCH BUILD.
                {
                    happyClock.gameObject.SetActive(false);
                    sadClock.gameObject.SetActive(false);
                }
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
                    // TURN OFF FOR SEARCH
                    if (!isAI) happyClock.gameObject.SetActive(true); // COMMENTED THIS LINE BECAUSE sadClock WAS NOT BEING DEACTIVATED ON ITCH BUILD.
                    //if (isAI == false) happyClock.gameObject.SetActive(true); // UNCOMMENT PREVIOUS LINE AND COMMENT THIS LINE WHEN PUSHING TO GIT. THIS LINE IS ONLY USED FOR ITCH BUILD.


                    food.amountFloat -= population.amountFloat;
                    money.amountFloat += (population.amountFloat * moneyMultiplier);
                    pollution.amountFloat += (population.amountFloat / pollutionDivider);
                    approval.amountFloat += (population.amountFloat / 5f);

                    if (timeMatters == true)
                    {
                        populationGrowthTurns++;

                        // NEW HUNGER COUNTER
                        hungerCounter--;
                        if (hungerCounter < hungerSevereThreshold)
                        {
                            
                            foodCrisisAutoAlert.alertIsOn = false;
                        }
                    }



                    if (needsRender == true)
                    {
                        moneySfx.Play();

                    }

                    if (populationGrowthTurns > growthThreshold)
                    {
                        populationGrowthTurns = 0f;
                        growthThreshold *= growthThresholdMultiplier;
                        //population.amountFloat += (population.amountFloat *= 1.2f);
                        population.amountFloat *= populationMultiplier;
                        if (!isAI) popPrompter.RunPrompt(); // COMMENTED THIS LINE BECAUSE sadClock WAS NOT BEING DEACTIVATED ON ITCH BUILD.
                        //if (isAI == false) popPrompter.RunPrompt(); // UNCOMMENT PREVIOUS LINE AND COMMENT THIS LINE WHEN PUSHING TO GIT. THIS LINE IS ONLY USED FOR ITCH BUILD.

                    }


                }

                else if (food.amountFloat < population.amountFloat)
                {
                    if (timeMatters == true)
                    {
                        // TURN OFF FOR SEARCH
                        if(needsRender == true)
                        {
                            sadClock.gameObject.SetActive(true);
                            angryCrowdSfx.Play();
                        }
                        

                        float foodPopDelta = ((population.amountFloat)-(population.amountFloat - food.amountFloat));

                        //food.amountFloat -= population.amountFloat;
                        food.amountFloat -= foodPopDelta;
                        money.amountFloat += foodPopDelta;
                        pollution.amountFloat += foodPopDelta;
                        approval.amountFloat -= (population.amountFloat / 5f);

                        // NEW HUNGER COUNTER
                        hungerCounter++;

                        //moneySfx.Play();

                        if (hungerCounter == hungerMildThreshold)
                        {
                            // CALL NEWS ARRIVING NOTIFICATION
                            // TURN OFF FOR SEARCH
                            //arrivingNews.gameObject.SetActive(true);
                            //worldIcon.ArrivingNotification();
                            //notificationSoundObj.gameObject.SetActive(true);
                            hungerNewsManager.activateNews();
                            foodCrisisAutoAlert.alertIsOn = false;
                        }

                        else if (hungerCounter > hungerMildThreshold && hungerCounter < hungerSevereThreshold)
                        {
                            // CALL NEWS ARRIVING NOTIFICATION
                            // TURN OFF FOR SEARCH
                            //arrivingNews.gameObject.SetActive(true);
                            //worldIcon.ArrivingNotification();
                            //notificationSoundObj.gameObject.SetActive(true);
                            //hungerNewsManager.activateNews();
                            foodCrisisAutoAlert.alertIsOn = false;
                        }

                        else if (hungerCounter /*> hungerMildThreshold && hungerCounter*/ >= hungerSevereThreshold)
                        {
                            // CALL CATACLYSM WINDOW
                            //firstCataclysmWindow.gameObject.SetActive(true);

                            // IT TAKES (FULFILING FOOD DEMAND) 4 TIMES TO EXIT CATACLYSM
                            //hungerCounter++;
                            //hungerCounter++;
                            //hungerCounter++;

                            hungerNewsManager.OpenCataclysmWindow();
                            foodCrisisAutoAlert.alertIsOn = true;
                        }
                    }
                }   
            }

        }



    }
}
