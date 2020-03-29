using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TradeOffDescriptorElem : MonoBehaviour
{
    //This class determines the tradeOffs, which will increase or decrease the counters of Resources or Products.

    public string reqName;
    public Amount targetResOrProd; //Add Amount Class to each TradeOffDescrElem.
    //public float quantPerClick;
    //public float costPerClick;
    //public bool autoIsActive;
    //public float quantPerSec;
    //public float costPerSec;
    public float tradeFloat; //This was used for UpDescrElem. Use quantPerClick or quantPerSec instead. CHOSE TO RATHER GO WITH THIS.

    public bool isPurchasable;
    public bool isAutomated;
    public string perClick = " / click";
    public string perSec = " / 1 sec";

    public bool elemIsEconomy;
    public bool elemIsFood;
    public bool elemIsEnergy;
    public bool elemIsWaste;
    public bool elemIsApproval;
    public bool isAdditive;

    public TextMeshProUGUI tradeOffTxt;

    //public int chosenIcon;
    public GameObject[] icons; //Goes 0-6.
    // 0 Economy
    // 1 Food
    // 2 Energy
    // 3 Waste
    // 4 approval
    // 5 is Positive
    // 6 is Negative

    public bool tradeIsResPassive;
    public bool tradeIsProduct;
    public bool tradeIsRes;

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
    public List<Resource> checkedRes = new List<Resource>();
    // 0 food
    // 1 energy
    // 2 waste



    //END OF REFERENCES ////////////////////////////////////////////////////////////////////////////

    

    public void VerifyIsPurchasable()
    {
        if (tradeIsResPassive == true)
        {
            if (isAdditive == false)
            {
                if (checkedResPassive[chosenResPassive].resourceCurrent.amountFloat >= tradeFloat)
                {
                    isPurchasable = true;
                }
                else
                {
                    isPurchasable = false;

                }
            }

            else
            {
                isPurchasable = true;

            }
        }

        if (tradeIsProduct == true)
        {
            if (isAdditive == false)
            {
                if (checkedProduct[chosenProduct].amountTxt.amountFloat >= tradeFloat)
                {
                    isPurchasable = true;
                }
                else
                {
                    isPurchasable = false;

                }
            }
            else
            {
                isPurchasable = true;

            }
        }

        if (tradeIsRes == true)
        {
            if (isAdditive == false)
            {
                if (checkedRes[chosenRes].resourceCurrent.amountFloat >= tradeFloat)
                {
                    isPurchasable = true;
                }
                else
                {
                    isPurchasable = false;

                }
            }
            else
            {
                isPurchasable = true;

            }
        }
    }

    public void Update()
    {
        //VerifyIsPurchasable(); //This is done in UpgradeDescriptor class.

        //Turns on the correct sign.
        if (isAdditive == true)
        {
            icons[5].gameObject.SetActive(true);
            icons[6].gameObject.SetActive(false);
        }
        else if (isAdditive == false)
        {
            icons[5].gameObject.SetActive(false);
            icons[6].gameObject.SetActive(true);
        }

        //Turns on the correct icon
        if (elemIsEconomy == true)
        {
            icons[0].gameObject.SetActive(true);

            icons[1].gameObject.SetActive(false);
            icons[2].gameObject.SetActive(false);
            icons[3].gameObject.SetActive(false);
            icons[4].gameObject.SetActive(false);

            if (tradeIsResPassive == true)
            {
                //if (isAdditive == true)
                //{
                //    icons[5].gameObject.SetActive(true);
                //    icons[6].gameObject.SetActive(false);
                //}
                //else
                //{
                //    icons[5].gameObject.SetActive(false);
                //    icons[6].gameObject.SetActive(true);
                //}

                tradeOffTxt.text = tradeFloat.ToString("0.00");

            }

            //else if (tradeIsProduct == true)
            //{

            //}

            //else if (tradeIsRes == true)
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
            //    requirementTxt.text = tradeFloat.ToString("0") + " " + checkedProduct[chosenProduct].productName;

            //}

            if (tradeIsProduct == true)
            {
                //if (isAdditive == true)
                //{
                //    icons[5].gameObject.SetActive(true);
                //    icons[6].gameObject.SetActive(false);
                //}
                //else
                //{
                //    icons[5].gameObject.SetActive(false);
                //    icons[6].gameObject.SetActive(true);
                //}

                tradeOffTxt.text = tradeFloat.ToString("0");

            }

            else if (tradeIsRes == true)
            {
                //if (isAdditive == true)
                //{
                //    icons[5].gameObject.SetActive(true);
                //    icons[6].gameObject.SetActive(false);
                //}
                //else
                //{
                //    icons[5].gameObject.SetActive(false);
                //    icons[6].gameObject.SetActive(true);
                //}

                tradeOffTxt.text = tradeFloat.ToString("0.0");

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
            //    requirementTxt.text = tradeFloat.ToString("0") + " " + checkedProduct[chosenProduct].productName;

            //}

            if (tradeIsProduct == true)
            {
                //if (isAdditive == true)
                //{
                //    icons[5].gameObject.SetActive(true);
                //    icons[6].gameObject.SetActive(false);
                //}
                //else
                //{
                //    icons[5].gameObject.SetActive(false);
                //    icons[6].gameObject.SetActive(true);
                //}

                tradeOffTxt.text = tradeFloat.ToString("0");

            }

            else if (tradeIsRes == true)
            {
                //if (isAdditive == true)
                //{
                //    icons[5].gameObject.SetActive(true);
                //    icons[6].gameObject.SetActive(false);
                //}
                //else
                //{
                //    icons[5].gameObject.SetActive(false);
                //    icons[6].gameObject.SetActive(true);
                //}

                tradeOffTxt.text = tradeFloat.ToString("0.0");

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
            //    requirementTxt.text = tradeFloat.ToString("0") + " " + checkedProduct[chosenProduct].productName;

            //}

            if (tradeIsProduct == true)
            {
                //if (isAdditive == true)
                //{
                //    icons[5].gameObject.SetActive(true);
                //    icons[6].gameObject.SetActive(false);
                //}
                //else
                //{
                //    icons[5].gameObject.SetActive(false);
                //    icons[6].gameObject.SetActive(true);
                //}

                tradeOffTxt.text = tradeFloat.ToString("0");

            }

            else if (tradeIsRes == true)
            {
                //if (isAdditive == true)
                //{
                //    icons[5].gameObject.SetActive(true);
                //    icons[6].gameObject.SetActive(false);
                //}
                //else
                //{
                //    icons[5].gameObject.SetActive(false);
                //    icons[6].gameObject.SetActive(true);
                //}

                tradeOffTxt.text = tradeFloat.ToString("0.0");

            }

        }
        else if (elemIsApproval == true)
        {
            icons[4].gameObject.SetActive(true);

            icons[1].gameObject.SetActive(false);
            icons[2].gameObject.SetActive(false);
            icons[3].gameObject.SetActive(false);
            icons[0].gameObject.SetActive(false);

            if (tradeIsResPassive == true)
            {
                //if (isAdditive == true)
                //{
                //    icons[5].gameObject.SetActive(true);
                //    icons[6].gameObject.SetActive(false);
                //}
                //else
                //{
                //    icons[5].gameObject.SetActive(false);
                //    icons[6].gameObject.SetActive(true);
                //}

                tradeOffTxt.text = tradeFloat.ToString("0");

            }

            //else if (tradeIsProduct == true)
            //{

            //}

            //else if (tradeIsRes == true)
            //{

            //}

        }
    }

}
