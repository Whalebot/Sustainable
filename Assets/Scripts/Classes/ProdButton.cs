using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProdButton : MonoBehaviour
{
    public string typeOfButton;
    public TradeOffDescriptor tradeDescriptor; //Used to trigger automation.

    public bool buttIsMultiplier;
    public bool isTriggeringAuto;
    public int multipliersPurchased = 0;
    public Button minusButton;

    public Product targetProductAmountt;
    //public List<Product> targetProdAmount = new List<Product>(); //Only adds.
    //public List<Amount> targetProdAmount = new List<Amount>(); Type is not Amount, but Product.
    //public Amount targetProdAmount; Is list, instead.

    public List<Resource> targetResAdd = new List<Resource>();
    //public Resource targetResAdd;
    public List<ResourcePassive> targetResPassAdd = new List<ResourcePassive>();

    public List<Resource> targetResSubtract = new List<Resource>();
    //public Resource targetResSubtract;
    public List<ResourcePassive> targetResPassSubtract = new List<ResourcePassive>();

    public List<Product> influencerProd = new List<Product>();
    //public Product influencerProd;

    //public bool lockIsActive;
    //public GameObject prodDescrLockGO; This is already in UI Info Hover Class.

    public UpButton keyUpgrade;
    public GameObject offButton;
    public GameObject lockObject;
    //public GameObject lockOffButton;

    // END OF REFERENCES ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

    public void Update()
    {
        if (buttIsMultiplier == true)
        {
            if (multipliersPurchased == 0)
            {
                DeactivateAutomation();

                tradeDescriptor.equalizeAutoFloat();

                minusButton.interactable = false;

                //if (buttIsMultiplier == true)
                //{
                //    minusButton.interactable = false;
                //}
            }
            else if (multipliersPurchased > 0)
            {
                ActivateAutomation();

                minusButton.interactable = true;

                //if (buttIsMultiplier == true)
                //{
                //    minusButton.interactable = true;
                //}
            }
        }
        

        //if (buttIsMultiplier == true)
        //{
        //    for (int i = 0; i < tradeDescriptor.requirements.Length; i++)
        //    {
        //        tradeDescriptor.requirements[i].isAutomated = true;
        //    }
        //}
    }

    public void AddMultiplier()
    {
        multipliersPurchased++;
    }

    public void SubtractMultiplier()
    {
        multipliersPurchased--;
    }

    public void Trade()
    {
        //float[] calculatorRes;
        //float[] calculatorResPass;



        //Used by OnClick();
        //targetProdAmount[0].amountTxt.amountFloat += influencerProd[0].quantPerClick;
        //foreach(Product targetProdAm in targetProdAmount)
        //{
        //    targetProdAm.amountTxt.amountFloat += influencerProd
        //}

        // THIS WAS FOREACH. DIDNT USE IT.
        //foreach (Product influencer in influencerProd)
        //{
        //    targetProductAmountt.amountTxt.amountFloat += influencer.quantPerClick;
        //}

        //targetResAdd[0].resourceCurrent.amountFloat += influencerProd[0].quantPerClick;
        //targetResPassAdd[0].resourceCurrent.amountFloat += influencerProd[0].quantPerClick;
        //targetResSubtract[0].resourceCurrent.amountFloat -= influencerProd[0].quantPerClick;
        //targetResPassSubtract[0].resourceCurrent.amountFloat -= influencerProd[0].quantPerClick;

    }

    public void ActivateAutomation()
    {
        tradeDescriptor.isAuto = true;
        Debug.Log("activated Auto in Descriptor.");
        
        //isTriggeringAuto = true;

        //if (isTriggeringAuto == true)
        //{
        //    tradeDescriptor.isAuto = true;
        //}
        //else if (isTriggeringAuto == false)
        //{
        //    tradeDescriptor.isAuto = false;

        //}
    }

    public void DeactivateAutomation()
    {
        tradeDescriptor.isAuto = false; // AQUI ESTABA EL PEDO? PORQUE ERA FALSE?

        //isTriggeringAuto = true;

        //if (isTriggeringAuto == true)
        //{
        //    tradeDescriptor.isAuto = true;
        //}
        //else if (isTriggeringAuto == false)
        //{
        //    tradeDescriptor.isAuto = false;

        //}
    }

    

}
