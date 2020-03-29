using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpgradeDescriptor : MonoBehaviour
{
    public UpButton upgradeButton;

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

    public void CheckRequirements()
    {
        for (int i = 0; i < requirements.Length; i++)
        {
            requirements[i].VerifyIsPurchasable();
            if (requirements[i].isPurchasable == true)
            {
                requirementIsChecked[i] = true;
            }
        }

        if (requirementIsChecked[0] == true && requirementIsChecked[1] == true)
        {
            upgradeButton.offButton.gameObject.SetActive(false); //I changed off Button to lockObject.
        }

        else if (requirementIsChecked[0] == true && requirementIsChecked[1] == true && requirementIsChecked[2] == true)
        {
            upgradeButton.offButton.gameObject.SetActive(false);
        }

        else if (requirementIsChecked[0] == true && requirementIsChecked[1] == true && requirementIsChecked[2] == true && requirementIsChecked[3] == true)
        {
            upgradeButton.offButton.gameObject.SetActive(false);
        }

        else
        {
            upgradeButton.offButton.gameObject.SetActive(true);
        }

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

            benefit.text = verb + " " + prodName;


        }

        else if (justNeedsUnlockOnce == false)
        {


            purchased.gameObject.SetActive(false);

            benefit.text = verb + " " + prodName + " " + byHowMuch + " " + perWhat + ".";

        }


    }

}
