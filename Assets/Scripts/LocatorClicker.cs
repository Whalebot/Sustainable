using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocatorClicker : MonoBehaviour
{
    public GameObject tradeOffWindow;

    public Vector3 windowScaleIntro;
    public Vector3 windowScaleOutro;
    public float distanceInside;
    public float distanceOutside;
    public float speed;

    public AnimationCurve curveIn;
    public AnimationCurve curveOut;

    public void Start()
    {
        tradeOffWindow.gameObject.SetActive(false);
    }

    public void OnMouseDown()
    {
        tradeOffWindow.gameObject.SetActive(true);
        LeanTween.scale(tradeOffWindow, windowScaleIntro, speed).setEase(curveIn);
        LeanTween.moveLocalY(tradeOffWindow, distanceInside, speed).setEase(curveIn);
    }

    public void CloseTradeOffWindow()
    {
        LeanTween.scale(tradeOffWindow, windowScaleOutro, speed).setEase(curveOut);
        LeanTween.moveLocalY(tradeOffWindow, distanceOutside, speed).setEase(curveOut);
    }
}
