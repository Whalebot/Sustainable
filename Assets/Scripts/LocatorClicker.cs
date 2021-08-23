using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LocatorClicker : MonoBehaviour
{
    public SimpleAI aiObject;
    public GameObject tradeOffWindow;
    public bool usesInvisibles;
    public GameObject invisTradeWin; // THIS IS FOR INVISIBLE TRADE OFF WINDOW.
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
    public GameObject invisAutomator; // THIS IS FOR INVISIBLE AUTOMATOR DIV.
    public bool winHasPopUp;
    public Vector3 popScaleStart = new Vector3(0f, 0f, 0f);
    public Vector3 popScaleBig;
    public float popUpSpeed;
    public float popUpDelay;
    public AnimationCurve popUpEase;

    public bool isUsedForTutorial;
    public bool isFood;
    public bool isEnergy;
    public bool isWasteM;
    public bool hasFulfilledTutorial;
    public Tut2 tutManager3;
    public ArrowActivator tutManag3;
    public Tut2 tutManager4;
    public ArrowActivator tutManag4;
    public ArrowActivator tutManag42;
    public Tut2 tutManager5;
    public ArrowActivator tutManag5;


    public UiInner miles;
    public UiInner resources;
    public UiInner footer;

    public float pauseDelay;
    public float originalAiSpeed;


    public void Start()
    {
        //if (isPolicies == true)
        //{
        //originalAiSpeed = aiObject.timeSpeed;
        //}

        //tradeOffWindow.gameObject.SetActive(false); Since the window is outside the camera view, it should be fine.

        if (usesInvisibles == true)
        {
            LeanTween.scale(tradeOffWindow, windowScaleOutro, 0f); //This starts the TradeOffWindow in windowScaleOutro scale.
            LeanTween.scale(invisTradeWin, windowScaleOutro, 0f); //This starts the TradeOffWindow in windowScaleOutro scale.

            nameTag.gameObject.SetActive(false);

            //START FOR POPUP
            popScaleBig = new Vector3(1f, 1f, 1f);
            if (winHasPopUp == true)
            {
                LeanTween.scale(automatorDiv, popScaleStart, 0f);
                LeanTween.scale(invisAutomator, popScaleStart, 0f);


            }

        }
        else if (usesInvisibles == false)
        {
            LeanTween.scale(tradeOffWindow, windowScaleOutro, 0f); //This starts the TradeOffWindow in windowScaleOutro scale.

            nameTag.gameObject.SetActive(false);

            //START FOR POPUP
            popScaleBig = new Vector3(1f, 1f, 1f);
            if (winHasPopUp == true)
            {
                LeanTween.scale(automatorDiv, popScaleStart, 0f);

            }

        }

        

    }

    public void ZTutorialize()
    {
        if (hasFulfilledTutorial == false)
        {
            if (isUsedForTutorial == true)
            {
                if (isFood)
                {
                    //tutCounter++;
                    tutManager3.Z2CloseTxtDiv();
                    tutManag3.ZDeactivateArrow();

                    tutManager4.Z0OpenTxtDiv();
                    tutManager4.Z1SwitchTxt();
                    tutManag4.ZActivateArrow();


                    miles.Z1TabSwipesUp();
                    resources.Z1TabSwipesUp();
                    footer.Z1TabSwipesUp();


                    hasFulfilledTutorial = true;
                }

                else if (isEnergy)
                {
                    //tutCounter++;


                    //tutManager4.Z0OpenTxtDiv();
                    tutManager4.Z2CloseTxtDiv();
                    tutManag42.ZDeactivateArrow();

                    tutManager5.Z0OpenTxtDiv();
                    tutManager5.Z1SwitchTxt();
                    tutManag5.ZActivateArrow();

                    //miles.Z1TabSwipesUp();
                    //resources.Z1TabSwipesUp();
                    //footer.Z1TabSwipesUp();


                    hasFulfilledTutorial = true;
                }
                
            }

            

        }


    }

    public void OnMouseDown()
    {
        ZTutorialize();

        CloseOtherWindows();
        mouse_down = true;
        nameTag.gameObject.SetActive(false);



        // IF IsPolicies == True, THEN JUMP TO UPGRADE PANEL.
        if (isPolicies == false)
        {
            if (usesInvisibles == true)
            {
                tradeOffWindow.gameObject.SetActive(true);
                LeanTween.scale(tradeOffWindow, windowScaleIntro, speed).setEase(curveIn);
                LeanTween.moveLocalY(tradeOffWindow, distanceInside, speed).setEase(curveIn);

                invisTradeWin.gameObject.SetActive(true);
                LeanTween.scale(invisTradeWin, windowScaleIntro, speed).setEase(curveIn);
                LeanTween.moveLocalY(invisTradeWin, distanceInside, speed).setEase(curveIn);

                //THIS CHANGES CAM POSITION.
                Vector3 camCenterVector = new Vector3(islandPos.position.x, islandPos.position.y, islandPos.position.z);
                LeanTween.moveLocal(camParent, camCenterVector, camSpeed).setEase(curveEaseInOut);

                //THIS POPS UP AUTOMATORDIV.
                if (winHasPopUp == true)
                {
                    /*automatorDiv.*/
                    PopUpScaler();
                }
            }
            else if (usesInvisibles == false)
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
                    /*automatorDiv.*/
                    PopUpScaler();
                }
            }


        }
        else if (isPolicies == true)
        {
            //THIS CHANGES CAM POSITION.
            Vector3 camCenterVector = new Vector3(islandPos.position.x, islandPos.position.y, islandPos.position.z);
            LeanTween.moveLocal(camParent, camCenterVector, camSpeed).setEase(curveEaseInOut);

            LeanTween.scale(tradeOffWindow, windowScaleIntro, speed).setEase(curveIn); // THIS MOVES tradeOffWin inside.
            LeanTween.moveLocalY(tradeOffWindow, distanceInside, speed).setEase(curveIn);

            StartCoroutine(JumpToUpgradePanelCoroutine());
            PauseTime();

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
        if (usesInvisibles == true)
        {
            LeanTween.scale(tradeOffWindow, windowScaleOutro, speed).setEase(curveOut);
            LeanTween.moveLocalY(tradeOffWindow, distanceOutside, outSpeed).setEase(curveOut);

            LeanTween.scale(invisTradeWin, windowScaleOutro, speed).setEase(curveOut);
            LeanTween.moveLocalY(invisTradeWin, distanceOutside, outSpeed).setEase(curveOut);


            //THIS POPS DOWN AUTOMATORDIV.
            if (winHasPopUp == true)
            {
                /*automatorDiv.*/
                PopDownScaler();
            }
        }

        else if (usesInvisibles == false)
        {
            LeanTween.scale(tradeOffWindow, windowScaleOutro, speed).setEase(curveOut);
            LeanTween.moveLocalY(tradeOffWindow, distanceOutside, outSpeed).setEase(curveOut);

            //THIS POPS DOWN AUTOMATORDIV.
            if (winHasPopUp == true)
            {
                /*automatorDiv.*/
                PopDownScaler();
            }
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
        if (usesInvisibles == true)
        {
            LeanTween.scale(automatorDiv, popScaleBig, speed).setDelay(popUpDelay).setEase(popUpEase);
            LeanTween.scale(invisAutomator, popScaleBig, speed).setDelay(popUpDelay).setEase(popUpEase);


        }

        else if (usesInvisibles == false)
        {
            LeanTween.scale(automatorDiv, popScaleBig, speed).setDelay(popUpDelay).setEase(popUpEase);

        }

    }

    public void PopDownScaler()
    {
        if (usesInvisibles == true)
        {
            LeanTween.scale(automatorDiv, popScaleStart, 0f).setDelay(popUpDelay).setEase(popUpEase);
            LeanTween.scale(invisAutomator, popScaleStart, 0f).setDelay(popUpDelay).setEase(popUpEase);

        }

        else if (usesInvisibles == false)
        {
            LeanTween.scale(automatorDiv, popScaleStart, 0f).setDelay(popUpDelay).setEase(popUpEase);

        }


    }

    public void PauseTime()
    {
        if (isPolicies == true)
        {
            StartCoroutine(PauseSimulationCoroutine());
        }

    }

    public void ResumeTime()
    {
        if (isPolicies == true)
        {
            if (aiObject.isAIActive == true)
            {
                aiObject.timeSpeed = originalAiSpeed;
            }

            else if (aiObject.isAIActive == false)
            {
                Time.timeScale = 1;
            }
        }
    }

    IEnumerator PauseSimulationCoroutine()
    {
        // FIRST WAIT.        
        yield return new WaitForSeconds(camSpeed + pauseDelay);
        // aiObject.timeSpeed == 0;
        //if (aiObject.isAIActive == true)
        //{
        //    aiObject.timeSpeed = 0f;

        //}

        //else if (aiObject.isAIActive == false)
        //{
        //    Time.timeScale = 0;
        //}

    }

}
