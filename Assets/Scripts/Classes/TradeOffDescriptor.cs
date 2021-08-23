using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TradeOffDescriptor : MonoBehaviour
{
    public bool isAutomatorWithBoat;
    public Button[] automatorOffButton;

    // END OF BOAT REFS.

    // REFS FOR TOGGLING DESCRIPTOR WINDOWS EVEN IF TRADE BACKGROUND PANELS ARE OFF.
    public bool buttonsUseMiniTabs;
    public GameObject buttonsPanel;
    public GameObject descriptorWindowPanel;

    public bool elemIsAmountless;
    public ProdButton productButton;
    public GameObject[] prodOffButtons;
    public UiInfoHoverer prodButtUiInfoHoverer;
    public bool isPerSec;
    public string reqWarning = "Max requirements,.length should be 5.";
    public TradeOffDescriptorElem[] requirements;
    public bool[] requirementIsChecked;

    public string prodName;
    public bool isAuto;

    // END OF REFERENCES //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



    public void MultiplyAutoFloat()
    {
        for (int i = 0; i < requirements.Length; i++)
        {
            requirements[i].autoFloat *= requirements[i].multiplier;
        }
    }

    public void DivideAutoFloat()
    {
        if (productButton.multipliersPurchased > 0)
        {
            for (int i = 0; i < requirements.Length; i++)
            {
                requirements[i].autoFloat /= requirements[i].multiplier;
            }
        }
    }

    public void Start()
    {
        for (int i = 0; i < prodOffButtons.Length; i++)
        {
            prodOffButtons[i].gameObject.SetActive(false);
        }
        requirementIsChecked = new bool[requirements.Length];
    }

    public void equalizeAutoFloat()
    {
        for (int i = 0; i < requirements.Length; i++)
        {
            requirements[i].autoFloat = requirements[i].originalAutoFloat;
        }
    }

    public void ExecuteElementsAuto()
    {
        if (isAuto == true)
        {
            Debug.Log("isAuto is " + isAuto);

            if (requirements[0].isAutopurchasable == false)
            {
                isPerSec = false;

                if (isAutomatorWithBoat == true)
                {
                    for (int i = 0; i < automatorOffButton.Length; i++)
                    {
                        automatorOffButton[i].onClick.Invoke();
                    }
                }
            }

            else if (requirements[1].isAutopurchasable == false)
            {
                isPerSec = false;

                if (isAutomatorWithBoat == true)
                {
                    for (int i = 0; i < automatorOffButton.Length; i++)
                    {
                        automatorOffButton[i].onClick.Invoke();
                    }
                }
            }

            else if (requirements[2].isAutopurchasable == false)
            {
                isPerSec = false;

                if (isAutomatorWithBoat == true)
                {
                    for (int i = 0; i < automatorOffButton.Length; i++)
                    {
                        automatorOffButton[i].onClick.Invoke();
                    }
                }
            }

            else if (requirements[3].isAutopurchasable == false)
            {
                isPerSec = false;

                if (isAutomatorWithBoat == true)
                {
                    for (int i = 0; i < automatorOffButton.Length; i++)
                    {
                        automatorOffButton[i].onClick.Invoke();
                    }
                }
            }

            else if (requirements[4].isAutopurchasable == false)
            {
                isPerSec = false;

                if (isAutomatorWithBoat == true)
                {
                    for (int i = 0; i < automatorOffButton.Length; i++)
                    {
                        automatorOffButton[i].onClick.Invoke();
                    }
                } 
            }

            else if (requirements[5].isAutopurchasable == false)
            {
                isPerSec = false;

                if (isAutomatorWithBoat == true)
                {
                    for (int i = 0; i < automatorOffButton.Length; i++)
                    {
                        automatorOffButton[i].onClick.Invoke();
                    }
                }
            }

            else if (requirements[6].isAutopurchasable == false)
            {
                isPerSec = false;

                if (isAutomatorWithBoat == true)
                {
                    for (int i = 0; i < automatorOffButton.Length; i++)
                    {
                        automatorOffButton[i].onClick.Invoke();
                    }
                }

            }

            else if (requirements[0].isAutopurchasable == true && requirements[1].isAutopurchasable == true && requirements[2].isAutopurchasable == true && requirements[3].isAutopurchasable == true 
                && requirements[4].isAutopurchasable == true && requirements[5].isAutopurchasable == true && requirements[6].isAutopurchasable == true)
            {

                for (int i = 0; i < requirements.Length; i++)
                {
                    //requirements[i].isAutomated = true;
                    requirements[i].ExecuteAutoTrade();
                    Debug.Log("Asking to execute AutoTrade() in requirement.");

                }
            }
            
        }
    }

    public void ExecuteElementsTrade()
    {
        string elems = "";
        string elemamount = "";
        for (int i = 0; i < requirements.Length; i++)
        {
            if (!requirements[i].isUnused)
            {
                elems += requirements[i].reqName + ";";
                elemamount += requirements[i].tradeFloat + ";";
            }
            requirements[i].ExecuteTrade();
        }
        if (FindObjectOfType<Telemetry>() != null)
        {
            if (FindObjectOfType<Telemetry>().enabled) StartCoroutine(FindObjectOfType<Telemetry>().Post(this.name, "Small Scale", this.transform.parent.name, elems, elemamount));
        }
    }

    public void UnlockDescriptor()
    {
        //prodButtUiInfoHoverer.buttonLockIsActive = false;
        //descrLockDiv.gameObject.SetActive(false);
        prodButtUiInfoHoverer.descriptorLockDiv.gameObject.SetActive(false);

    }

    public void Update()
    {
        ExecuteElementsAuto();
        if (elemIsAmountless == true)
        {
            for (int i = 0; i < requirements.Length; i++)
            {
                requirements[i].isAmountless = true;
            }
        }

        else if (elemIsAmountless == false)
        {
            for (int i = 0; i < requirements.Length; i++)
            {
                requirements[i].isAmountless = false;
            }
        }


        // NOW, UPDATE CHECKS IF "PER SEC" SHOULD APPEAR, USING UiInfoHoverer.
        if (prodButtUiInfoHoverer.isAutomatorOrMulti == true)
        {
            for (int i = 0; i < requirements.Length; i++)
            {
                requirements[i].isAutomated = true;
            }
        }
        else if (prodButtUiInfoHoverer.isAutomatorOrMulti == false)
        {
            for (int i = 0; i < requirements.Length; i++)
            {
                requirements[i].isAutomated = false;
            }
        }


        //CheckRequirements(); // Will do the OffButton magic in TradeOffDescrElem Class.
        if (productButton.lockObject.activeInHierarchy)
        {
            prodOffButtons[5].gameObject.SetActive(true);
            prodButtUiInfoHoverer.descriptorLockDiv.gameObject.SetActive(true);
            //productButton.offButton.gameObject.SetActive(true);
        }
        else
        {
            prodOffButtons[5].gameObject.SetActive(false);
            prodButtUiInfoHoverer.descriptorLockDiv.gameObject.SetActive(false);

            //productButton.offButton.gameObject.SetActive(false);

        }

        if (buttonsUseMiniTabs == true)
        {
            if (buttonsPanel.activeInHierarchy == true)
            {
                descriptorWindowPanel.gameObject.SetActive(true);

            }
            else if (buttonsPanel.activeInHierarchy == false)
            {
                descriptorWindowPanel.gameObject.SetActive(false);

            }
        }
    }
}
