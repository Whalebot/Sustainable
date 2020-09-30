using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CursorChanger : MonoBehaviour, IPointerEnterHandler, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
    // REF FOR RENDER.
    public bool needsRender;

    // REF FOR TYPE OF CURSOR CONTEXT.
    public bool isCursorClickable;
    public bool isCursorInformative;
    public bool isCursorBlocked;
    public bool isCursorIndustrial;
    public CursorStart cursorManager;
    public bool usesTutorial;

    public bool mouse_over = false;
    public bool mouse_over_clicked = false;

    public void Start()
    {
        cursorManager = GameObject.Find("Cursor Manager").GetComponent<CursorStart>();

        

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        cursorManager.isBusyWithButton = true;

        mouse_over = true;

        if (isCursorClickable == true)
        {
            if (needsRender == true)
            {
                Cursor.SetCursor(cursorManager.cursorClickable, Vector2.zero, CursorMode.ForceSoftware);

               
            }
        }

        if (isCursorInformative == true)
        {
            if (needsRender == true)
            {
                Cursor.SetCursor(cursorManager.cursorInfo, Vector2.zero, CursorMode.ForceSoftware);
            }
        }

        if (isCursorBlocked == true)
        {
            if (needsRender == true)
            {
                Cursor.SetCursor(cursorManager.cursorBlocked, Vector2.zero, CursorMode.ForceSoftware);
            }
        }

        if (isCursorIndustrial == true)
        {
            if (needsRender == true)
            {
                Cursor.SetCursor(cursorManager.cursorIndustrial, Vector2.zero, CursorMode.ForceSoftware);
            }
        }

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (isCursorClickable)
        {
            if (mouse_over == true)
            {
                mouse_over_clicked = true;

                Cursor.SetCursor(cursorManager.cursorClickdown, Vector2.zero, CursorMode.ForceSoftware);

                if (usesTutorial == true)
                {
                    mouse_over = false;
                    mouse_over_clicked = false;
                    cursorManager.isBusyWithButton = false;
                    //Cursor.SetCursor(cursorManager.cursorGeneral, Vector2.zero, CursorMode.ForceSoftware);
                }

            }
        }

        else if (isCursorIndustrial)
        {
            if (mouse_over == true)
            {
                mouse_over_clicked = true;

                Cursor.SetCursor(cursorManager.cursorIndustrialdown, Vector2.zero, CursorMode.ForceSoftware);

                if (usesTutorial == true)
                {
                    mouse_over = false;
                    mouse_over_clicked = false;
                    cursorManager.isBusyWithButton = false;
                    //Cursor.SetCursor(cursorManager.cursorGeneral, Vector2.zero, CursorMode.ForceSoftware);
                }

            }
        }

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (isCursorClickable)
        {
            if (mouse_over == true)
            {
                if (mouse_over_clicked == true)
                {

                    Cursor.SetCursor(cursorManager.cursorClickable, Vector2.zero, CursorMode.ForceSoftware);

                    mouse_over_clicked = false;

                }
            }
        }

        else if (isCursorIndustrial)
        {
            if (mouse_over == true)
            {
                if (mouse_over_clicked == true)
                {

                    Cursor.SetCursor(cursorManager.cursorIndustrial, Vector2.zero, CursorMode.ForceSoftware);

                    mouse_over_clicked = false;

                }
            }
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        cursorManager.isBusyWithButton = false;

        mouse_over = false;
        mouse_over_clicked = false;


        Cursor.SetCursor(cursorManager.cursorGeneral, Vector2.zero, CursorMode.ForceSoftware);

        


    }
}
