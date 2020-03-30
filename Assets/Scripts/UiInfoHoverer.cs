using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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

    //void Update()
    //{
    //    This only works for Upgrade Div
    //    if (thisObjectIsUpgradeWindow == true)
    //        {
    //            if (buttonLockIsActive == true)
    //            {
    //                buttonLockGameObject.gameObject.SetActive(true);
    //            }
    //            else if (buttonLockIsActive == false)
    //            {
    //                buttonLockGameObject.gameObject.SetActive(false);
    //            }
    //        }



    //    if (thisObjectIsTradeOffWindow == true) //THIS MUST GO IN TradeOffDescriptor but inverted! If Lock on TradeButton is active, lock in descriptor is active.
    //    {
    //        if (lockIsActive == true)
    //        {
    //            descriptorLockDiv.gameObject.SetActive(lockIsActive);
    //        }
    //        else if (lockIsActive == false)
    //        {
    //            descriptorLockDiv.gameObject.SetActive(lockIsActive);

    //        }
    //    }

    //}

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
