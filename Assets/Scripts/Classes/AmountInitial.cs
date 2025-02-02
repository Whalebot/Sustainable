﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmountInitial : MonoBehaviour
{
    public TextMeshProUGUI inputPlaceholder;
    public TextMeshProUGUI txt;
    public float inputAmount;
    //public bool affectsMultiple;
    public bool affectsSomeRes;
    public Amount someResAmount;
    //public bool pendingResAmount;
    public float[] multipliers;
    public bool affectsTrades;
    public bool affectsAuto;
    public TradeOffDescriptorElem[] trades;
    //public bool[] pendingTrades;
    public bool affectsUpgrades;
    public UpgradeDescriptorElem[] upgrades;
    //public bool[] pendingUpgrades;
    public bool affectsMultipliers;
    public PolicyManager managerMultiplier;
    //public Resource resource;
    //public ResourcePassive resPass;
    //public bool 
    //public string emptyString;
    //public float defaultAmount;

    public void Awake()
    {
        //defaultAmount = float.Parse(inputPlaceholder.text);
        inputAmount = float.Parse(inputPlaceholder.text);

        if (affectsSomeRes == true)
        {
            someResAmount.amountFloat = (float.Parse(inputPlaceholder.text)) /** (multipliers[i])*/;
        }

        else if (affectsTrades == true)
        {
            if (affectsAuto == true)
            {
                for (int i = 0; i < trades.Length; i++)
                {
                    trades[i].autoFloat = (float.Parse(inputPlaceholder.text)) * (multipliers[i]);
                }
            }

            else if (affectsAuto == false)
            {
                for (int i = 0; i < trades.Length; i++)
                {
                    trades[i].tradeFloat = (float.Parse(inputPlaceholder.text)) * (multipliers[i]);
                }
            }

        }

        else if (affectsUpgrades == true)
        {
            for (int i = 0; i < upgrades.Length; i++)
            {
                upgrades[i].requirementFloat = (float.Parse(inputPlaceholder.text)) * (multipliers[i]);
            }
        }

        else if (affectsMultipliers == true)
        {
            managerMultiplier.multiplier1 = (float.Parse(inputPlaceholder.text));
        }
    }

    public void Text_Changed(string newText)
    {
        inputAmount = float.Parse(newText);

        if (affectsSomeRes == true)
        {
            someResAmount.amountFloat = (float.Parse(newText))/* * (multipliers[i])*/;
            //Debug.Log(someResAmount.gameObject.name);
        }

        else if (affectsTrades == true)
        {
            if (affectsAuto == true)
            {
                for (int i = 0; i < trades.Length; i++)
                {
                    trades[i].autoFloat = (float.Parse(newText)) * (multipliers[i]);
                }
            }

            else if (affectsAuto == false)
            {
                for (int i = 0; i < trades.Length; i++)
                {
                    trades[i].tradeFloat = (float.Parse(newText)) * (multipliers[i]);
                }
            }
            
        }

        else if (affectsUpgrades == true)
        {
            for (int i = 0; i < upgrades.Length; i++)
            {
                upgrades[i].requirementFloat = (float.Parse(newText)) * (multipliers[i]);
            }
        }

        else if (affectsMultipliers == true)
        {
            managerMultiplier.multiplier1 = (float.Parse(newText)) * multipliers[0];
        }

    }

    //public void Update()
    //{
    //    if (affectsSomeRes == true)
    //    {
    //        someResAmount.amountFloat = inputAmount/* * (multipliers[i])*/;
    //        //Debug.Log(someResAmount.gameObject.name);
    //    }

    //    else if (affectsTrades == true)
    //    {
    //        if (affectsAuto == false)
    //        {
    //            for (int i = 0; i < trades.Length; i++)
    //            {
    //                trades[i].autoFloat = (float.Parse(newText)) * (multipliers[i]);
    //            }
    //        }

    //        else if (affectsAuto == false)
    //        {
    //            for (int i = 0; i < trades.Length; i++)
    //            {
    //                trades[i].tradeFloat = (float.Parse(newText)) * (multipliers[i]);
    //            }
    //        }

    //    }

    //    else if (affectsUpgrades == true)
    //    {
    //        for (int i = 0; i < upgrades.Length; i++)
    //        {
    //            upgrades[i].requirementFloat = (float.Parse(newText)) * (multipliers[i]);
    //        }
    //    }
    //}

    //public void Default()
    //{
    //    txt.text = emptyString;
    //}
}
