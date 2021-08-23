using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static TimeManager Instance { get; private set; }

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

    private void Awake()
    {
        Instance = this;
    }

    // NEWS REFS
    public HungerCatac hungerNewsManager;

    // CATACLYSM REFS
    public AutoAlert foodCrisisAutoAlert;

    public void Start()
    {
        needsRender = false;

        if (FindObjectOfType<SimpleAI>() == null)
        {
            isAI = false;
            happyClock.gameObject.SetActive(false);
            sadClock.gameObject.SetActive(false);
        }
        else
        {
            isAI = false; 
            happyClock.gameObject.SetActive(false);
            sadClock.gameObject.SetActive(false);

        }

        counter = 1f;

        timeIsRunning = true;
        StartCoroutine(TimeScheduleCoroutine());
    }

    public void NeedsRenderActivator()
    {
        needsRender = true;
    }

    public void PeopleCanGetHungry()
    {
        timeMatters = true;
    }

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

    public void AdvanceGameState() {
        counter++;
        if (counter > counterThreshold)
        {
            counter = 1f;
        }
        else if (counter == 2f)
        {
            if (isAI == false)
            {
                happyClock.gameObject.SetActive(false);
                sadClock.gameObject.SetActive(false);
            }
        }

        else if (counter == counterThreshold)
        {
            if (food.amountFloat >= population.amountFloat)
            {
                if (isAI == false)
                {
                    happyClock.gameObject.SetActive(true);
                    LeanTween.scale(clockParent, scaleBloat, (waitTimeUnit / 3)).setEase(curveBloat);
                    LeanTween.scale(clockParent, scaleUnbloat, (waitTimeUnit / 2)).setEase(curveEase).setDelay(waitTimeUnit);
                }

                food.amountFloat -= population.amountFloat;
                money.amountFloat += (population.amountFloat * moneyMultiplier);
                pollution.amountFloat += (population.amountFloat / pollutionDivider);
                approval.amountFloat += (population.amountFloat / 5f);

                if (timeMatters)
                {
                    populationGrowthTurns++;
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
                    population.amountFloat *= populationMultiplier;

                    if (isAI == false) 
                    { 
                        popPrompter.RunPrompt();
                        popIncreaseSfx.Play();

                    }  
                }


            }

            else if (food.amountFloat < population.amountFloat)
            {
                if (timeMatters == true)
                {
                    if (needsRender == true)
                    {
                        sadClock.gameObject.SetActive(true);
                        LeanTween.moveLocalY(clockParent, yDistance, (waitTimeUnit / 3)).setEase(curveSpring);
                        LeanTween.moveLocalY(clockParent, (0f), (waitTimeUnit / 2)).setEase(curveEase).setDelay(waitTimeUnit * 1.5f);
                        angryCrowdSfx.Play();
                    }


                    float foodPopDelta = ((population.amountFloat) - (population.amountFloat - food.amountFloat));
                    food.amountFloat -= foodPopDelta;
                    money.amountFloat += foodPopDelta;
                    pollution.amountFloat += foodPopDelta;
                    approval.amountFloat -= (population.amountFloat / 5f);

                    hungerCounter++;


                    if (hungerCounter == hungerMildThreshold)
                    {
                        hungerNewsManager.activateNews();
                        foodCrisisAutoAlert.alertIsOn = false;
                    }

                    else if (hungerCounter > hungerMildThreshold && hungerCounter < hungerSevereThreshold)
                    {
                        foodCrisisAutoAlert.alertIsOn = false;
                    }

                    else if (hungerCounter >= hungerSevereThreshold)
                    {
                        hungerNewsManager.OpenCataclysmWindow();
                        foodCrisisAutoAlert.alertIsOn = true;
                    }
                }
            }
        }

    }

    IEnumerator TimeScheduleCoroutine()
    {
        while (timeIsRunning == true)
        {
            yield return new WaitForSeconds(waitTimeUnit);
            AdvanceGameState();
        }
    }
}
