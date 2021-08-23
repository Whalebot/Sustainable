using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UiInfoHoverer : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
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
        if (isFooterTab == true)
        {
            specificDiv.gameObject.SetActive(false);

        }
        else if (isFooterTab == false)
        {
            LeanTween.moveLocalY(specificDiv, -1260f, 0); //Moves AnyDescriptor object outside screen. Instead of deactivating it.

        }

    }



    


    public void OnPointerEnter(PointerEventData eventData)
    {
        mouse_over = true;
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
