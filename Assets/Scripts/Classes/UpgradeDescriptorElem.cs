using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpgradeDescriptorElem : MonoBehaviour
{
    public bool isPurchasable;

    public bool elemIsEconomy;
    public bool elemIsFood;
    public bool elemIsEnergy;
    public bool elemIsWaste;
    public bool elemIsApproval;
    //public bool isAdditive;

    public TextMeshProUGUI requirementTxt;

    //public int chosenIcon;
    public List<GameObject> icons = new List<GameObject>(); //Goes 0-6.
    // 0 Economy
    // 1 Food
    // 2 Energy
    // 3 Waste
    // 4 approval
    // 5 is Positive
    // 6 is Negative

    public bool reqIsResPassive;
    public bool reqIsProduct;
    public bool reqIsLvl;

    public int chosenResPassive;
    public List<ResourcePassive> checkedResPassive = new List<ResourcePassive>();
    // 0 Economy
    // 1 Population
    // 2 Approval
    // 3 Pollution

    public int chosenProduct;
    public List<Product> checkedProduct = new List<Product>();
    // 0 Boats (EMPTY)
    // 1 Livestock
    // 2 Crops
    // 3 Fish
    // 4 Insects
    // 5 Algae
    // 6 Oil barrels
    // 7 Biofuel barrels
    // 8 Biogas tanks
    // 9 Artificial fertilizer
    // 10 Organic fertilizer
    // 11 Fish plastic
    // 12 organic waste
    // 13 plastic waste
    // 14 mixed waste (12.5)
    // 15 Recycled plastic (25)
    // 16 Soil (26)
    // 17 Water (27)

    public int chosenRes;
    public List<Resource> checkedResLvl = new List<Resource>();
    // 0 food
    // 1 energy
    // 2 waste

    public int requiredLvl;
    public float requirementFloat;

    // END OF REFERENCES. ////////////////////////////////////////////////////////////////////////////////////////

    public void VerifyIsPurchasable()
    {
        if (reqIsResPassive == true)
        {
            if (checkedResPassive[chosenResPassive].resourceCurrent.amountFloat >= requirementFloat)
            {
                isPurchasable = true;
            }
            else
            {
                isPurchasable = false;

            }
        }

        if (reqIsProduct == true)
        {
            if (checkedProduct[chosenProduct].amountTxt.amountFloat >= requirementFloat)
            {
                isPurchasable = true;
            }
            else
            {
                isPurchasable = false;

            }
        }

        if (reqIsLvl == true)
        {
            if (checkedResLvl[chosenRes].lvlCurrent.onlyLvl >= requiredLvl)
            {
                isPurchasable = true;
            }
            else
            {
                isPurchasable = false;

            }
        }
    }

    public void Update()
    {
        //VerifyIsPurchasable(); //This is done in UpgradeDescriptor class.

        //Turns on the correct icon
        if (elemIsEconomy == true)
        {
            icons[0].gameObject.SetActive(true);

            icons[1].gameObject.SetActive(false);
            icons[2].gameObject.SetActive(false);
            icons[3].gameObject.SetActive(false);
            icons[4].gameObject.SetActive(false);

            if (reqIsResPassive == true)
            {
                requirementTxt.text = requirementFloat.ToString("0.00");

            }

            //else if (reqIsProduct == true)
            //{

            //}

            //else if (reqIsLvl == true)
            //{

            //}

        }
        else if (elemIsFood == true)
        {
            icons[1].gameObject.SetActive(true);

            icons[0].gameObject.SetActive(false);
            icons[2].gameObject.SetActive(false);
            icons[3].gameObject.SetActive(false);
            icons[4].gameObject.SetActive(false);

            //if (reqIsResPassive == true)
            //{
            //    requirementTxt.text = requirementFloat.ToString("0") + " " + checkedProduct[chosenProduct].productName;

            //}

            if (reqIsProduct == true)
            {
                requirementTxt.text = requirementFloat.ToString("0") + " " + checkedProduct[chosenProduct].productName;

            }

            else if (reqIsLvl == true)
            {
                requirementTxt.text = "Level " + requiredLvl;

            }



        }
        else if (elemIsEnergy == true)
        {
            icons[2].gameObject.SetActive(true);

            icons[1].gameObject.SetActive(false);
            icons[0].gameObject.SetActive(false);
            icons[3].gameObject.SetActive(false);
            icons[4].gameObject.SetActive(false);

            //if (reqIsResPassive == true)
            //{
            //    requirementTxt.text = requirementFloat.ToString("0") + " " + checkedProduct[chosenProduct].productName;

            //}

            if (reqIsProduct == true)
            {
                requirementTxt.text = requirementFloat.ToString("0") + " " + checkedProduct[chosenProduct].productName;

            }

            else if (reqIsLvl == true)
            {
                requirementTxt.text = "Level " + requiredLvl;

            }

        }
        else if (elemIsWaste == true)
        {
            icons[3].gameObject.SetActive(true);

            icons[1].gameObject.SetActive(false);
            icons[2].gameObject.SetActive(false);
            icons[0].gameObject.SetActive(false);
            icons[4].gameObject.SetActive(false);

            //if (reqIsResPassive == true)
            //{
            //    requirementTxt.text = requirementFloat.ToString("0") + " " + checkedProduct[chosenProduct].productName;

            //}

            if (reqIsProduct == true)
            {
                requirementTxt.text = requirementFloat.ToString("0") + " " + checkedProduct[chosenProduct].productName;

            }

            else if (reqIsLvl == true)
            {
                requirementTxt.text = "Level " + requiredLvl;

            }

        }
        else if (elemIsApproval == true)
        {
            icons[4].gameObject.SetActive(true);

            icons[1].gameObject.SetActive(false);
            icons[2].gameObject.SetActive(false);
            icons[3].gameObject.SetActive(false);
            icons[0].gameObject.SetActive(false);

            if (reqIsResPassive == true)
            {
                requirementTxt.text = requirementFloat.ToString("0.0");

            }

            //else if (reqIsProduct == true)
            //{

            //}

            //else if (reqIsLvl == true)
            //{

            //}

        }
    }

}
