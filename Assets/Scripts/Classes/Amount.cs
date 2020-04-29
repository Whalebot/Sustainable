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
            //if (usesProperty == true)
            //{
                if (value > _amountFloat)
                {
                    //lerpTime = 0f;
                    //currentCol = Color.Lerp(originalCol, lightCol, lerpTime);
                    if (usesProperty == true)
                    {
                        //currentCol = Color.Lerp(originalCol, lightCol, 1f);
                        LeanTween.alpha(lightObj1, 255f, waitSec).setEase(curve);
                        LeanTween.alpha(lightObj1, 0f, waitSec).setEase(curve).setDelay(delay);

                        LeanTween.alpha(lightObj2, 255f, waitSec).setEase(curve);
                        LeanTween.alpha(lightObj2, 0f, waitSec).setEase(curve).setDelay(delay);

                        //uCurrentCol = Color.Lerp(uOriginalCol, uLightCol, 1f);

                        //StartCoroutine(positiveCoroutine());

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
                    //lerpTime = 0f;
                    //currentCol = Color.Lerp(originalCol, darkCol, lerpTime);

                    if (usesProperty == true)
                    {
                    //currentCol = Color.Lerp(originalCol, darkCol, 1f);
                    LeanTween.alpha(darkObj1, 255f, waitSec).setEase(curve);
                    LeanTween.alpha(darkObj1, 0f, waitSec).setEase(curve).setDelay(delay);

                    LeanTween.alpha(darkObj2, 255f, waitSec).setEase(curve);
                    LeanTween.alpha(darkObj2, 0f, waitSec).setEase(curve).setDelay(delay);

                    //uCurrentCol = Color.Lerp(uOriginalCol, uDarkCol, 1f);

                    //StartCoroutine(negativeCoroutine());

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
                _change = _amountFloat - value;
                _amountFloat = value;
        } 

            //else if (usesProperty == false)
            //{
            //    Debug.Log("Amount does not use property");
            //}
               
        //}
    }


    public bool objectIsLvl = false;
    public int onlyLvl; //Only use this reference if GameObj is a milestone Level.
    public bool objectIsMilestone = false;
    public float onlyMilePrev; //Only write here if 
    //public GameObject amountIcon;
    //public List<GameObject> amountIcon = new List<GameObject>();

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

    public Image universalFill;
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
                universalFill.color = uCurrentCol;

                fill2.color = currentCol;
            }
            
            else if (isTab == false)
            {
                fill.color = currentCol;
                universalFill.color = uCurrentCol;
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

        //else if (usesProperty == true)
        //{

        //    if (isTab == true)
        //    {
        //        fill.color = currentCol;
        //        universalFill.color = uCurrentCol;

        //        fill2.color = currentCol;

        //    }
        //    else if (isTab == false)
        //    {
        //        fill.color = currentCol;
        //        universalFill.color = uCurrentCol;

        //    }

        //}

    }

    //IEnumerator positiveCoroutine()
    //{
    //    Debug.Log("amount increased");
    //    //currentCol = Color.Lerp(originalCol, lightCol, 0.5f);
    //    yield return new WaitForSeconds(waitSec);
    //    //lerpTime = 0f;
    //    //currentCol = Color.Lerp(lightCol, originalCol, lerpTime);
    //    currentCol = Color.Lerp(lightCol, originalCol, 1f);
    //    uCurrentCol = Color.Lerp(uLightCol, uOriginalCol, 1f);


    //}

    //IEnumerator negativeCoroutine()
    //{
    //    Debug.Log("amount decreased");
    //    //currentCol = Color.Lerp(originalCol, darkCol, 0.5f);
    //    yield return new WaitForSeconds(waitSec);
    //    //lerpTime = 0f;
    //    //currentCol = Color.Lerp(darkCol, originalCol, lerpTime);
    //    currentCol = Color.Lerp(darkCol, originalCol, 1f);
    //    uCurrentCol = Color.Lerp(uDarkCol, uOriginalCol, 1f);


    //}




}
