using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpgradeDescriptor : MonoBehaviour
{
    public UpButton upgradeButton;
    // REFS FOR TOGGLING DESCRIPTOR WINDOWS EVEN IF TRADE BACKGROUND PANELS ARE OFF.
    public bool buttonsUseMiniTabs;
    public GameObject buttonsPanel;
    public GameObject descriptorWindowPanel;

    //public List<UpgradeDescriptorElem> Requirements = new List<UpgradeDescriptorElem>(); I need array.length, which I cannot get with this list...
    public string reqWarning = "Max requirements.length should be 4.";
    public UpgradeDescriptorElem[] requirements; //Right now, this should only hold 4 requirements.
    public int requirementsMet;
    public bool[] requirementIsChecked;
    
    public GameObject purchased;
    public bool upIsPurchased;

    public TextMeshProUGUI benefit;
    //public bool unlocks;
    //public bool increases;
    //public bool decreases;
    public bool justNeedsUnlockOnce;
    public string verb;
    //public Upgrade upName;
    public string prodName;
    public string byHowMuch;
    public string perWhat;
    //public bool perClick;
    //public bool perSec;

    public void Start()
    {
        requirementIsChecked = new bool[requirements.Length];
    }

    public void CheckRequirements() // THIS GUY IS TURNING OFF OFFBUTTONS ON UPDATE!
    {
        for (int i = 0; i < requirements.Length; i++)
        {
            requirements[i].VerifyIsPurchasable();
            if (requirements[i].isPurchasable == true)
            {
                requirementIsChecked[i] = true;
            }
        }

        //THIS WAS USED TO TURN ON OFFBUTTON OF UPBUTTON, BUT NOW THIS IS DONE IN UpgradeDescriptorElem!!!!!!!!!!!!
        //if (requirementIsChecked[0] == true && requirementIsChecked[1] == true)
        //{
        //    upgradeButton.offButton.gameObject.SetActive(false); //I changed off Button to lockObject.
        //}

        //else if (requirementIsChecked[0] == true && requirementIsChecked[1] == true && requirementIsChecked[2] == true)
        //{
        //    upgradeButton.offButton.gameObject.SetActive(false);
        //}

        //else if (requirementIsChecked[0] == true && requirementIsChecked[1] == true && requirementIsChecked[2] == true && requirementIsChecked[3] == true)
        //{
        //    upgradeButton.offButton.gameObject.SetActive(false);
        //}

        //else
        //{
        //    upgradeButton.offButton.gameObject.SetActive(true);
        //}



        //for (int i = 0; i < requirements.Length; i++)
        //{
        //    if (requirements[i].isPurchasable == true)
        //    {
        //        requirementsMet++;
        //    }

        //    requirementsMet++;

        //}

        //if (requirementsMet >= requirements.Length)
        //{
        //    upgradeButton.lockObject.gameObject.SetActive(false);
        //}
        //else
        //{
        //    upgradeButton.lockObject.gameObject.SetActive(true);

        //}

    }

    public void ExecuteUpRequirements()
    {
        string elems = "";
        string elemamount = "";
        for (int i = 0; i < requirements.Length; i++)
        {
            if (requirements[i].elemIsEconomy) { elems += "economy" + ";"; }
            else if(requirements[i].elemIsApproval) { elems += "approval" + ";"; }
            else if (requirements[i].elemIsEnergy) { elems += "energy" + ";"; }
            else if (requirements[i].elemIsFood) { elems += "food" + ";"; }
            else if (requirements[i].elemIsWaste) { elems += "waste" + ";"; }
            elemamount += requirements[i].requirementFloat + ";";
            requirements[i].ExecuteUpPurchase();
        }
        if (FindObjectOfType<Telemetry>() != null)
        {
            if(FindObjectOfType<Telemetry>().enabled) StartCoroutine(FindObjectOfType<Telemetry>().Post(this.name, "Upgrade", this.transform.parent.parent.name, elems, elemamount));
        }
    }

    public void Update()
    {
        CheckRequirements();


        if (justNeedsUnlockOnce == true)
        {
            if (upIsPurchased == true)
            {
                purchased.gameObject.SetActive(true);
            }
            else if (upIsPurchased == false)
            {
                purchased.gameObject.SetActive(false);

            }

            //if (verb == "Affects")
            //{
            //    benefit.text = verb + " " + prodName + ":";
            //}

            //else if (verb != "Affects")
            //{
            //    benefit.text = verb + " " + prodName;
            //}



        }

        //else if (justNeedsUnlockOnce == false)
        //{


        //    purchased.gameObject.SetActive(false);

        //    benefit.text = verb + " " + prodName + " " + byHowMuch + " " + perWhat + ".";

        //}

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
