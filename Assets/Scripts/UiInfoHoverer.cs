using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UiInfoHoverer : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject specificDiv;

    //This will have to change, once I have the Descriptor Class.
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
        specificDiv.gameObject.SetActive(false);
    }

    void Update()
    {
        if (mouse_over)
        {
            Debug.Log("Mouse Over");
        }

        //This only works for Upgrade Div
        if (thisObjectIsUpgradeWindow == true)
        {
            if (buttonLockIsActive == true)
            {
                buttonLockGameObject.gameObject.SetActive(true);
            }
            else if (buttonLockIsActive == false)
            {
                buttonLockGameObject.gameObject.SetActive(false);
            }
        }
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        mouse_over = true;
        Debug.Log("Mouse enter");
        specificDiv.gameObject.SetActive(true);

        //This will have to change, once I have the Descriptor Class.
        if (thisObjectIsTradeOffWindow == true)
        {
            if (lockIsActive == true)
            {
                descriptorLockDiv.gameObject.SetActive(lockIsActive);
            }
            else if (lockIsActive == false)
            {
                descriptorLockDiv.gameObject.SetActive(lockIsActive);

            }
        }

            
        
       
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouse_over = false;
        Debug.Log("Mouse exit");
        specificDiv.gameObject.SetActive(false);

    }

}
