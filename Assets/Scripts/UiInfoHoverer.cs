using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UiInfoHoverer : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    //// REF FOR RENDER.
    //public bool needsRender;

    //// REF FOR TYPE OF CURSOR CONTEXT.
    //public bool isCursorClickable;
    //public bool isCursorInformative;
    //public CursorStart cursorManager;


    public GameObject specificDiv;

    //This will have to change, once I have the Descriptor Class.
    public bool isAutomatorOrMulti;
    public bool isFooterTab;
    public bool thisObjectIsTradeOffWindow;
    public GameObject descriptorLockDiv;
    public bool lockIsActive;

    //This will affect the lock icon object of TradeOffWindow, without the need to hover on button. It will also have to change, once I have a Descriptor class.
    public bool thisObjectIsUpgradeWindow;
    public GameObject buttonLockGameObject;
    public bool buttonLockIsActive;

    private bool mouse_over = false;
    //private bool mouse_over_clicked = false;

    public void Start()
    {
        //cursorManager = GameObject.Find("Cursor Manager").GetComponent<CursorStart>();

        if (isFooterTab == true)
        {
            specificDiv.gameObject.SetActive(false);

        }
        else if (isFooterTab == false)
        {
            LeanTween.moveLocalY(specificDiv, -1260f, 0); //Moves AnyDescriptor object outside screen. Instead of deactivating it.

        }

    }

    //public void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        if (mouse_over == true)
    //        {
    //            mouse_over_clicked = true;

    //            if (needsRender == true)
    //            {
    //                if (isCursorClickable == true)
    //                {
    //                    Cursor.SetCursor(cursorManager.cursorClickdown, Vector2.zero, CursorMode.ForceSoftware);
    //                }
    //            }
    //        }
    //    }

    //    else if (Input.GetMouseButtonUp(0))
    //    {
    //        if (mouse_over == true)
    //        {
    //            if (mouse_over_clicked == true)
    //            {

    //                if (needsRender == true)
    //                {
    //                    if (isCursorClickable == true)
    //                    {
    //                        Cursor.SetCursor(cursorManager.cursorClickable, Vector2.zero, CursorMode.ForceSoftware);
    //                    }
    //                }
    //                mouse_over_clicked = false;

    //            }
    //        }
    //    }
    //}

    


    public void OnPointerEnter(PointerEventData eventData)
    {
        mouse_over = true;

        //if (isCursorClickable == true)
        //{
        //    if (needsRender == true)
        //    {
        //        Cursor.SetCursor(cursorManager.cursorClickable, Vector2.zero, CursorMode.ForceSoftware);

        //    }
        //}

        //if (isCursorInformative == true)
        //{
        //    if (needsRender == true)
        //    {
        //        Cursor.SetCursor(cursorManager.cursorInfo, Vector2.zero, CursorMode.ForceSoftware);
        //    }
        //}

        if (isFooterTab == true)
        {
            specificDiv.gameObject.SetActive(true);

        }

        else if (isFooterTab == false)
        {
            if (thisObjectIsUpgradeWindow == true)
            {
                LeanTween.moveLocalY(specificDiv, -180.7f, 0); //Moves UpDescriptor object inside screen. Instead of activating it.

            }
            else if (thisObjectIsTradeOffWindow == true)
            {
                LeanTween.moveLocalY(specificDiv, -226.8f, 0); //Moves TradeOffDescriptor object inside screen. Instead of activating it.

            }

            //This will have to change, once I have the Descriptor Class.
        }






    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouse_over = false;

        //Cursor.SetCursor(cursorManager.cursorGeneral, Vector2.zero, CursorMode.ForceSoftware);

        if (isFooterTab == true)
        {
            specificDiv.gameObject.SetActive(false);

        }

        else if (isFooterTab == false)
        {
            LeanTween.moveLocalY(specificDiv, -1260f, 0); //Moves AnyDescriptor object outside screen. Instead of deactivating it.

        }


    }

}
