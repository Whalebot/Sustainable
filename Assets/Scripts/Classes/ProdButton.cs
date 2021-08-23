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

    public List<Resource> targetResAdd = new List<Resource>();
    public List<ResourcePassive> targetResPassAdd = new List<ResourcePassive>();

    public List<Resource> targetResSubtract = new List<Resource>();
    public List<ResourcePassive> targetResPassSubtract = new List<ResourcePassive>();

    public List<Product> influencerProd = new List<Product>();
    public UpButton keyUpgrade;
    public GameObject offButton;
    public GameObject lockObject;

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
        tradeDescriptor.isAuto = false; 
    }
}
