using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopIncreasedPrompter : MonoBehaviour
{
    public float waitTime;
    public float animTime;
    public AnimationCurve curve;
    public RectTransform parent;
    public float distanceUp;
    public float distanceDown;

    public Vector3 scaleZero;
    public Vector3 scaleOne;

    public void Start()
    {
        LeanTween.scale(parent, scaleZero, 0f);

    }

    //public void Update()
    //{
    //    if (Input.GetKey("k"))
    //    {
    //        RunPrompt();
    //    }
    //}

    public void RunPrompt()
    {
        StartCoroutine(PromptCoroutine());
    }

    IEnumerator PromptCoroutine()
    {
        LeanTween.scale(parent, scaleOne, animTime).setEase(curve);
        yield return new WaitForSeconds(waitTime);
        LeanTween.scale(parent, scaleZero, animTime).setEase(curve);



    }
}
