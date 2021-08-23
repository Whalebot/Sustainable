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
    public GameObject clockParent;
    public AnimationCurve curveEase;
    public AnimationCurve curveBloat;
    public AnimationCurve curveSpring;
    public Vector3 scaleBloat;
    public Vector3 scaleUnbloat;
    public float yDistance;
    public AudioSource angryCrowdSfx;
    public AudioSource popIncreaseSfx;

    // HUNGER COUNTERS REFS
    public float hungerCounter;
    public float hungerMildThreshold;
    public float hungerSevereThreshold;
    public float maxHungerCounter;
    public bool isAI;

    // NEWS REFS
    public HungerCatac hungerNewsManager;

    // CATACLYSM REFS
    public AutoAlert foodCrisisAutoAlert;

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
            //isAI = true; // UNCOMMENT FOR BOTS // COMMENTED THIS LINE BECAUSE sadClock WAS NOT BEING DEACTIVATED ON ITCH BUILD.
            isAI = false; // COMMENT FOR BOTS // THIS LINE IS ONLY USED FOR ITCH BUILD.
            happyClock.gameObject.SetActive(false); // COMMENT FOR BOTS
            sadClock.gameObject.SetActive(false); // COMMENT FOR BOTS

        }

        counter = 1f;
        //sellingPoint = 0f;
        //growthThreshold = 3f;
        timeIsRunning = true;
        StartCoroutine(TimeScheduleCoroutine());
    }

    public void AdvanceGameState() {

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

            if (counter > counterThreshold)
            {
                counter = 1f;
                
                
            }

            else if (counter == 2f) 
            {
                //if (!isAI) // UNCOMMENT FOR BOTS.
                if (isAI == false) // COMMENT FOR BOTS.
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
                    //if (!isAI) happyClock.gameObject.SetActive(true); // UNCOMMENT FOR BOTS.
                    if (isAI == false) // COMMENT FOR BOTS.
                    {   // COMMENT FOR BOTS
                        happyClock.gameObject.SetActive(true); // COMMENT FOR BOTS.
                        LeanTween.scale(clockParent, scaleBloat, (waitTimeUnit/3)).setEase(curveBloat); // COMMENT FOR BOTS
                        LeanTween.scale(clockParent, scaleUnbloat, (waitTimeUnit / 2)).setEase(curveEase).setDelay(waitTimeUnit); // COMMENT FOR BOTS

                    }   // COMMENT FOR BOTS

                    food.amountFloat -= population.amountFloat;
                    money.amountFloat += (population.amountFloat * moneyMultiplier);
                    pollution.amountFloat += (population.amountFloat / pollutionDivider);
                    approval.amountFloat += (population.amountFloat / 5f);

                    if (timeMatters)
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

                        //if (!isAI) popPrompter.RunPrompt(); // UNCOMMENT FOR BOTS.
                        if (isAI == false) // COMMENT FOR BOTS.
                        {   // COMMENT FOR BOTS
                            popPrompter.RunPrompt(); // COMMENT FOR BOTS
                            popIncreaseSfx.Play(); // COMMENT FOR BOTS

                        }   // COMMENT FOR BOTS
                    }


                }

                else if (food.amountFloat < population.amountFloat)
                {
                    print("Not enough foood!");
                    if (timeMatters == true)
                    {
                        // TURN OFF FOR SEARCH
                        if (needsRender == true)
                        {
                            sadClock.gameObject.SetActive(true);
                            LeanTween.moveLocalY(clockParent, yDistance, (waitTimeUnit / 3)).setEase(curveSpring); 
                            LeanTween.moveLocalY(clockParent, (0f), (waitTimeUnit / 2)).setEase(curveEase).setDelay(waitTimeUnit * 1.5f); 
                            angryCrowdSfx.Play();
                        }


                        float foodPopDelta = ((population.amountFloat) - (population.amountFloat - food.amountFloat));

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
