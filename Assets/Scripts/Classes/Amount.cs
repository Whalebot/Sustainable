using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Amount : MonoBehaviour
{
    public string amountKind;
    public bool isProduct;
    public TextMeshProUGUI amountTxt;

    public bool usesProperty;
    public bool isTab;
    public float _amountFloat;
    public float _change;
    public float amountFloat
    {
        get { return _amountFloat; }
        set
        {
            if (value > _amountFloat)
            {
                if (usesProperty == true)
                {
                    LeanTween.alpha(lightObj1, 255f, waitSec).setEase(curve);
                    LeanTween.alpha(lightObj1, 0f, waitSec).setEase(curve).setDelay(delay);

                    LeanTween.alpha(lightObj2, 255f, waitSec).setEase(curve);
                    LeanTween.alpha(lightObj2, 0f, waitSec).setEase(curve).setDelay(delay);

                }
                else if (usesProperty == false)
                {
                    //Debug.Log("Doesn't use property");
                    if (isLinkedToNews == true)
                    {
                        newsMan.CheckThresholds();

                    }
                }
            }
            else if (value < _amountFloat)
            {
                if (usesProperty == true)
                {
                    LeanTween.alpha(darkObj1, 255f, waitSec).setEase(curve);
                    LeanTween.alpha(darkObj1, 0f, waitSec).setEase(curve).setDelay(delay);

                    LeanTween.alpha(darkObj2, 255f, waitSec).setEase(curve);
                    LeanTween.alpha(darkObj2, 0f, waitSec).setEase(curve).setDelay(delay);
                    if (isPopulation == true)
                    {
                        popIncreasedPrompter.newPop = (amountFloat - foodCrisisAutoAlertColl.alertCost);
                    }

                }
                else if (usesProperty == false)
                {
                    if (isLinkedToNews == true)
                    {
                        newsMan.CheckThresholds();

                    }
                }
            }
            _change = _amountFloat - value;
            _amountFloat = value;
        }
    }


    public bool objectIsLvl = false;
    public int onlyLvl; //Only use this reference if GameObj is a milestone Level.
    public bool objectIsMilestone = false;
    public float onlyMilePrev; //Only write here if 

    // REFS FOR FEEDBACK COLOR CHANGE;
    public float delay;
    public AnimationCurve curve;
    public Image fill;
    public RectTransform lightObj1;
    public RectTransform darkObj1;
    public Image fill2;
    public RectTransform lightObj2;
    public RectTransform darkObj2;
    public Color currentCol;
    public Color originalCol;
    public Color lightCol;
    public Color darkCol;

    //public Image universalFill;
    public Color uCurrentCol;
    public Color uOriginalCol;
    public Color uLightCol;
    public Color uDarkCol;

    //public float lerpTime;
    public float duration;
    public float waitSec;

    //REFS FOR NEWS NOTIFICATIONS.
    public NewsManager newsMan;
    public bool isLinkedToNews;

    // REFS FOR Population Prompter Notification
    public PopIncreasedPrompter popIncreasedPrompter;
    public AutoAlertCollateral foodCrisisAutoAlertColl;
    public bool isPopulation;

    public void Start()
    {
        if (usesProperty == true)
        {
            currentCol = originalCol;
            uCurrentCol = uOriginalCol;

            LeanTween.alpha(lightObj1, 0f, 0f);
            LeanTween.alpha(darkObj1, 0f, 0f);

            LeanTween.alpha(lightObj2, 0f, 0f);
            LeanTween.alpha(darkObj2, 0f, 0f);

            if (isTab == true)
            {
                fill.color = currentCol;
                //universalFill.color = uCurrentCol;

                fill2.color = currentCol;
            }

            else if (isTab == false)
            {
                fill.color = currentCol;
                //universalFill.color = uCurrentCol;
            }
        }

        else if (usesProperty == false)
        {
            currentCol = originalCol;
            uCurrentCol = uOriginalCol;

            //fill.color = currentCol;
            //universalFill.color = uCurrentCol;
        }



    }

    public void Update()
    {
        if (isProduct == true)
        {
            if (amountFloat < 0)
            {
                amountFloat = 0f;
            }
        }
    }
}
