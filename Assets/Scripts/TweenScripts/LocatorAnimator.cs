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

    // REF TO Cursor Manager.
    public CursorStart cursorManager;
    public bool clicked;
    // DRAG WILL BE DEACTIVATED WHEN CURSOR CLICKS.
    public MouseDragRay camMouseDragRay;
    public GameObject tutorialCanvas;
    public TutorialMasksAnimator tutorialMasksSequencer;

    // REFS FOR TUTORIAL MASKS ANIMATOR
    public Animator masksAnimator;
    public TutorialMasksAnimator tutorialMasksManager;
    public bool isUsedForTutorial;
    public TimeMachine sellingTimeManager;

    public void SetSequencerThreeD()
    {
        if (isUsedForTutorial == true)
        {
            if (tutorialCanvas.activeInHierarchy == true)
            {
                tutorialMasksManager.sequencerInteger++;
                masksAnimator.SetInteger("Sequencer", tutorialMasksManager.sequencerInteger);

                sellingTimeManager.NeedsRenderActivator();
            }
        }
    }

    public void Start()
    {
        locatorNormalColor.gameObject.SetActive(true);
        locatorColored.gameObject.SetActive(false);

        camMouseDragRay = GameObject.Find("Cinemachine PARENT C#").GetComponent<MouseDragRay>();
        cursorManager = GameObject.Find("Cursor Manager").GetComponent<CursorStart>();
        //tutorialCanvas = GameObject.Find("Canvas TUTORIAL");
    }

    public void OnMouseDown()
    {
        clicked = true;
        camMouseDragRay.isFreeNow = false;
        Cursor.SetCursor(cursorManager.cursorClickdown, Vector2.zero, CursorMode.ForceSoftware);

        LeanTween.scale(Pivot[selectedPivot], mouseUpScaleIntensity, mouseUpScaleTime).setEase(downCurve).setLoopPingPong(loops);

        SetSequencerThreeD();
    }

    public void OnMouseUp()
    {
        clicked = false;
        //if (tutorialCanvas.gameObject.activeInHierarchy == false)
        if (tutorialMasksSequencer.sequencerInteger >= 12)
        {
            camMouseDragRay.isFreeNow = true;
        }

        else if (tutorialMasksSequencer.sequencerInteger < 12 && tutorialCanvas.gameObject.activeInHierarchy == false)
        {
            camMouseDragRay.isFreeNow = true;
        }
        Cursor.SetCursor(cursorManager.cursorClickable, Vector2.zero, CursorMode.ForceSoftware);

    }

    public void OnMouseOver()
    {
        cursorManager.isBusyWithButton = true;
        if (clicked == false)
        {
            Cursor.SetCursor(cursorManager.cursorClickable, Vector2.zero, CursorMode.ForceSoftware);
        }

        //LeanTween.scale(Pivot, mouseOverIntensity, mouseOverExitTime).setEase(overExitCurve);
        locatorNormalColor.gameObject.SetActive(false);
        locatorColored.gameObject.SetActive(true);
    }

    public void OnMouseExit()
    {
        cursorManager.isBusyWithButton = false;
        Cursor.SetCursor(cursorManager.cursorGeneral, Vector2.zero, CursorMode.ForceSoftware);

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
