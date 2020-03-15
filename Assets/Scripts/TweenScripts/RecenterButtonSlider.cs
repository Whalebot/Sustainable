using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecenterButtonSlider : MonoBehaviour
{
    public float distance;
    public float speed;

    public AnimationCurve curve;


    public void SlideInButton()
    {
        LeanTween.moveY(gameObject, distance, speed).setEase(curve);
    }

    public void SlideOutButton()
    {
        LeanTween.moveY(gameObject, -distance, speed).setEase(curve);
    }
}
