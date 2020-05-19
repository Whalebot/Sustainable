using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialArrowAnimator : MonoBehaviour
{
    public GameObject objeto;
    public float xPositive;
    public float xNegative;
    public AnimationCurve curve;
    public float tiempo;
    public bool timeIsRunning;

    public bool usesX;
    public bool usesY;

    public void Start()
    {
        
        timeIsRunning = true;
        StartCoroutine(TimeScheduleCoroutine());
    }

    IEnumerator TimeScheduleCoroutine()
    {
        while (timeIsRunning == true)
        {
            if (usesX == true)
            {
                LeanTween.moveLocalX(objeto, xPositive, tiempo).setEase(curve);
                yield return new WaitForSeconds(tiempo);
                LeanTween.moveLocalX(objeto, xNegative, tiempo).setEase(curve);
                yield return new WaitForSeconds(tiempo);
            }
            
            else if (usesY == true)
            {
                LeanTween.moveLocalY(objeto, xPositive, tiempo).setEase(curve);
                yield return new WaitForSeconds(tiempo);
                LeanTween.moveLocalY(objeto, xNegative, tiempo).setEase(curve);
                yield return new WaitForSeconds(tiempo);
            }


        }




    }

}
