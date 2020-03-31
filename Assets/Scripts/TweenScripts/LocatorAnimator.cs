using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LocatorAnimator : MonoBehaviour
{
    public GameObject[] Pivot;
    public int selectedPivot;

    public Vector3 mouseUpScaleIntensity;
    public float mouseUpScaleTime;

    public GameObject locatorColored;
    public GameObject locatorNormalColor;

    public int loops;
    public AnimationCurve downCurve;

    public float shrinkSpeed;
    public float unshrinkSpeed;
    public float unshrinkDelay;
    public AnimationCurve shrinkCurve;

    

    public void Start()
    {
        locatorNormalColor.gameObject.SetActive(true);
        locatorColored.gameObject.SetActive(false);

    }

    public void OnMouseDown()
    {
        LeanTween.scale(Pivot[selectedPivot], mouseUpScaleIntensity, mouseUpScaleTime).setEase(downCurve).setLoopPingPong(loops);
    }

    public void OnMouseOver()
    {
        //LeanTween.scale(Pivot, mouseOverIntensity, mouseOverExitTime).setEase(overExitCurve);
        locatorNormalColor.gameObject.SetActive(false);
        locatorColored.gameObject.SetActive(true);
    }

    public void OnMouseExit()
    {
        //LeanTween.scale(Pivot, mouseExitIntensity, mouseOverExitTime).setEase(overExitCurve);
        locatorNormalColor.gameObject.SetActive(true);
        locatorColored.gameObject.SetActive(false);

        

    }

    public void ShrinkLocator()
    {
        Vector3 shrinkScale = new Vector3 (0f, 0f, 0f);
        for (int i = 0; i < Pivot.Length; i++)
        {
            LeanTween.scale(Pivot[i], (shrinkScale), shrinkSpeed).setEase(shrinkCurve);
        }
    }

    public void UnshrinkLocator()
    {
        Vector3 shrinkScale = new Vector3(0f, 0f, 0f);
        Vector3 unshrinkScale = new Vector3(1f, 1f, 1f);
        //LeanTween.scale(Pivot, (shrinkScale), shrinkSpeed).setDelay(1f);
        for (int i = 0; i < Pivot.Length; i++)
        {
            LeanTween.scale(Pivot[i], (unshrinkScale), unshrinkSpeed).setDelay(unshrinkDelay).setEase(shrinkCurve);
        }
    }
}
