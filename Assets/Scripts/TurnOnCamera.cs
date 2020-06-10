using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnCamera : MonoBehaviour
{
    public GameObject virtualCam;
    public bool hasWait;
    public float waitTime;

    public LocatorAnimator locAnim;

    public UiInner mileInner;
    public UiInner resInner;
    public UiInner resPasInner;

    public MouseDragRay mouseDragger;

    public TutorialOffer tutOffer;

    public void ActivateCamera()
    {
        if (hasWait == false)
        {
            virtualCam.gameObject.SetActive(true);

        }

        else if (hasWait == true)
        {
            //virtualCam.gameObject.SetActive(true);

            StartCoroutine(CameraPacerCoroutine());

        }
    }

    IEnumerator CameraPacerCoroutine()
    {
        
        yield return new WaitForSeconds(waitTime);
        virtualCam.gameObject.SetActive(true);
        locAnim.UnshrinkLocator();

        yield return new WaitForSeconds(waitTime);
        mileInner.Z1TabSwipesUp();
        resInner.Z1TabSwipesUp();
        resPasInner.Z1TabSwipesUp();
        mouseDragger.FreeDrag();
        tutOffer.TurnOffTutorialObj();


    }
}
