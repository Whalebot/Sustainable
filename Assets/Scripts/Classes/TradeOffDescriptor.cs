using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TradeOffDescriptor : MonoBehaviour
{
    public ProdButton productButton;
    public GameObject descrLockDiv;

    //public List<UpgradeDescriptorElem> Requirements = new List<UpgradeDescriptorElem>(); I need array.length, which I cannot get with this list...
    public string reqWarning = "Max requirements.length should be 4.";
    public TradeOffDescriptorElem[] requirements; //Right now, this should only hold 4 requirements.
    //public int requirementsMet; //Using bools instead.
    public bool[] requirementIsChecked;

    //public GameObject purchased;
    //public bool upIsPurchased;

    //public TextMeshProUGUI benefit;
    //public bool unlocks;
    //public bool increases;
    //public bool decreases;
    //public bool justNeedsUnlockOnce;
    //public string verb;
    //public Upgrade upName;
    public string prodName;
    //public string byHowMuch;
    //public string perWhat;
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

        if (productButton.lockObject.gameObject.activeInHierarchy)
        {
            productButton.offButton.gameObject.SetActive(false);
        }
        else
        {
            if (requirementIsChecked[0] == true && requirementIsChecked[1] == true)
            {
                productButton.offButton.gameObject.SetActive(false);
            }

            else if (requirementIsChecked[0] == true && requirementIsChecked[1] == true && requirementIsChecked[2] == true)
            {
                productButton.offButton.gameObject.SetActive(false);
            }

            else if (requirementIsChecked[0] == true && requirementIsChecked[1] == true && requirementIsChecked[2] == true && requirementIsChecked[3] == true)
            {
                productButton.offButton.gameObject.SetActive(false);
            }

            else
            {
                productButton.offButton.gameObject.SetActive(true);
            }
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
        //    productButton.offButton.gameObject.SetActive(false);
        //}
        //else
        //{
        //    productButton.offButton.gameObject.SetActive(true);

        //}

    }

    public void UnlockDescriptor()
    {
        descrLockDiv.gameObject.SetActive(false);
    }

    public void Update()
    {
        CheckRequirements();

         //THIS MUST GO IN TradeOffDescriptor but inverted! If Lock on TradeButton is active, lock in descriptor is active.
        
            
        

        //if (justNeedsUnlockOnce == true)
        //{
        //    if (upIsPurchased == true)
        //    {
        //        purchased.gameObject.SetActive(true);
        //    }
        //    else if (upIsPurchased == false)
        //    {
        //        purchased.gameObject.SetActive(false);

        //    }

        //    benefit.text = verb + " " + prodName;


        //}

        //else if (justNeedsUnlockOnce == false)
        //{


        //    purchased.gameObject.SetActive(false);

        //    benefit.text = verb + " " + prodName + " " + byHowMuch + " " + perWhat + ".";

        //}


    }

}
