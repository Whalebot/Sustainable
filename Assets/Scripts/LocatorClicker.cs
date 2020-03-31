﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LocatorClicker : MonoBehaviour
{
    public GameObject tradeOffWindow;
    public LocatorClicker[] otherInteractors; // USED TO CLOSE OTHER WINDOWS.
    public bool isPolicies;
    public TestCameraSwitcher cameraSwitcher;
    public LocatorAnimator locatorAnimator;

    public Vector3 windowScaleIntro;
    public Vector3 windowScaleOutro;
    public float distanceInside;
    public float distanceOutside;
    public float speed;
    public float outSpeed;

    public AnimationCurve curveIn;
    public AnimationCurve curveOut;
    public AnimationCurve curveEaseInOut;

    //TRANSFORM REFS
    public GameObject camParent;
    public Transform islandPos;
    public float camSpeed;
    public float policyJumpDelay;

    //REF USED TO SHOW NAME TAGS.
    //private bool mouse_over = false;
    public GameObject nameTag;
    public bool mouse_down;

    //REF FOR POPUP.
    //public PopUpScaleTweener automatorDiv;
    public GameObject automatorDiv;
    public bool winHasPopUp;
    public Vector3 popScaleStart = new Vector3(0f, 0f, 0f);
    public Vector3 popScaleBig;
    public float popUpSpeed;
    public float popUpDelay;
    public AnimationCurve popUpEase;



    public void Start()
    {
        //tradeOffWindow.gameObject.SetActive(false); Since the window is outside the camera view, it should be fine.
        LeanTween.scale(tradeOffWindow, windowScaleOutro, 0f); //This starts the TradeOffWindow in windowScaleOutro scale.

        nameTag.gameObject.SetActive(false);

        //START FOR POPUP
        popScaleBig = new Vector3(1f, 1f, 1f);
        if (winHasPopUp == true)
        {
            LeanTween.scale(automatorDiv, popScaleStart, 0f);

        }

    }

    public void OnMouseDown()
    {
        CloseOtherWindows();
        mouse_down = true;
        nameTag.gameObject.SetActive(false);



        // IF IsPolicies == True, THEN JUMP TO UPGRADE PANEL.
        if (isPolicies == false)
        {
            tradeOffWindow.gameObject.SetActive(true);
            LeanTween.scale(tradeOffWindow, windowScaleIntro, speed).setEase(curveIn);
            LeanTween.moveLocalY(tradeOffWindow, distanceInside, speed).setEase(curveIn);

            //THIS CHANGES CAM POSITION.
            Vector3 camCenterVector = new Vector3(islandPos.position.x, islandPos.position.y, islandPos.position.z);
            LeanTween.moveLocal(camParent, camCenterVector, camSpeed).setEase(curveEaseInOut);

            //THIS POPS UP AUTOMATORDIV.
            if (winHasPopUp == true)
            {
                /*automatorDiv.*/PopUpScaler();
            }
        }
        else if (isPolicies == true)
        {
            //THIS CHANGES CAM POSITION.
            Vector3 camCenterVector = new Vector3(islandPos.position.x, islandPos.position.y, islandPos.position.z);
            LeanTween.moveLocal(camParent, camCenterVector, camSpeed).setEase(curveEaseInOut);

            StartCoroutine(JumpToUpgradePanelCoroutine());

            //JumpToUpgradePanel(); // MOVED TO COROUTINE.
            //locatorAnimator.ShrinkLocator();
        }

    }

    IEnumerator JumpToUpgradePanelCoroutine()
    {
        // FIRST WAIT.        
        yield return new WaitForSeconds(camSpeed + policyJumpDelay);
        JumpToUpgradePanel();
        locatorAnimator.ShrinkLocator();

    }

    public void CloseTradeOffWindow()
    {
        LeanTween.scale(tradeOffWindow, windowScaleOutro, speed).setEase(curveOut);
        LeanTween.moveLocalY(tradeOffWindow, distanceOutside, outSpeed).setEase(curveOut);

        //THIS POPS DOWN AUTOMATORDIV.
        if (winHasPopUp == true)
        {
            /*automatorDiv.*/PopDownScaler();
        }
    }

    public void CloseOtherWindows()
    {
        for (int i = 0; i < otherInteractors.Length; i++)
        {
            otherInteractors[i].CloseTradeOffWindow();
        }
    }

    public void JumpToUpgradePanel()
    {
        if (isPolicies == true)
        {
            cameraSwitcher.OnMouseUp();
        }
    }

    public void OnMouseOver()
    {
        nameTag.gameObject.SetActive(true);

        if (mouse_down == true)
        {
            nameTag.gameObject.SetActive(false);

        }

    }

    public void OnMouseExit()
    {
        nameTag.gameObject.SetActive(false);
        mouse_down = false;

    }

    public void PopUpScaler()
    {
        LeanTween.scale(automatorDiv, popScaleBig, speed).setDelay(popUpDelay).setEase(popUpEase);
    }

    public void PopDownScaler()
    {
        LeanTween.scale(automatorDiv, popScaleStart, 0f).setDelay(popUpDelay).setEase(popUpEase);

    }

}
