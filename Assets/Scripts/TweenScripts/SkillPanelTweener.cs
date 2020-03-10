using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillPanelTweener : MonoBehaviour
{
    public float distance = 0f;
    public float speed = 0f;
    public float delay = 0f;

    //public MoneyManager moneyManager;

    public AnimationCurve curve;
    //public LeanTweenType easeType;


    public void SkillPanelUpper()
    {
        LeanTween.moveLocalY(gameObject, distance, speed).setEase(curve);
    }

    public void SkillPanelDowner()
    {
        LeanTween.moveLocalY(gameObject, -distance, speed).setEase(curve);
    }

}
