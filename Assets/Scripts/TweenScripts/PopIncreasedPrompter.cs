using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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

    public Amount popAmount;
    public TextMeshProUGUI txtPrevPop;
    public TextMeshProUGUI txtNewPop;
    public TextMeshProUGUI outlinePrevPop;
    public TextMeshProUGUI outlineNewPop;

    public float previousPop;
    public float newPop;

    public void Start()
    {
        LeanTween.scale(parent, scaleZero, 0f);
        newPop = popAmount.amountFloat;

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

        // THESE TWO LINES UPDATE Pop Floats:
        previousPop = newPop;
        newPop = popAmount.amountFloat;

        // THESE 4 LINES RENDER Pop Floats:
        txtPrevPop.text = previousPop.ToString("0");
        txtNewPop.text = newPop.ToString("0");
        outlinePrevPop.text = previousPop.ToString("0");
        outlineNewPop.text = newPop.ToString("0");

    }

    IEnumerator PromptCoroutine()
    {
        LeanTween.scale(parent, scaleOne, animTime).setEase(curve);
        yield return new WaitForSeconds(waitTime);
        LeanTween.scale(parent, scaleZero, animTime).setEase(curve);



    }
}
