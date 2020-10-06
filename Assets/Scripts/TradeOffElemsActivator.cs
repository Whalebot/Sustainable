using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TradeOffElemsActivator : MonoBehaviour
{
    public AutoEnergy autoEnergyManager;
    public GameObject[] tradeElemsObjToActivate;
    public TradeOffDescriptorElem[] theSameTradeElems;
    public TradeOffDescriptorElem manualEnergyUpgMoney;
    public TradeOffDescriptorElem autoEnergyUpgMoney;
    public TradeOffDescriptorElem manualMoneyProdCost;
    public TradeOffDescriptorElem autoMoneyProdCost;
    public TradeOffDescriptorElem manualEnergyProd;
    public TradeOffDescriptorElem autoEnergyProd;
    public float catacHealer;
    public bool oilWarHappened;
    public bool migrated;

    // REFS FOR TRADE ENERGY UPG AmountSimples
    public AmountSimple manualEnergyUpgAmountSimple;
    public AmountSimple autoEnergyUpgAmountSimple;

    public string newManualName;
    public TextMeshProUGUI energyManualUpgButt;
    public string newAutoName;
    public TextMeshProUGUI energyAutoUpgButt;

    public void oilWarActivator()
    {
        oilWarHappened = true;
    }

    public void ActivateElems()
    {
        for (int i = 0; i < tradeElemsObjToActivate.Length; i++)
        {
            tradeElemsObjToActivate[i].gameObject.SetActive(true);
        }

        ChangeName();
        InvertUnused();
        Migrate();
    }

    public void ChangeName()
    {
        // UPDATE NAME OF BUTTONS WITH Biogas NAMES.

        energyManualUpgButt.text = newManualName;
        energyAutoUpgButt.text = newAutoName;
    }

    public void InvertUnused()
    {
        // ACTIVATED ELEMENTS WILL SHOW IN TradeDescriptors AND THEIR VALUES WILL BE USED WHEN ExecuteTrades() HAPPEN.
        for (int i = 0; i < theSameTradeElems.Length; i++)
        {
            theSameTradeElems[i].isUnused = false;
            theSameTradeElems[i].isOpaque = false;

        }

        // multipliers ARE UPDATED. SO, INSTEAD OF INCREASING, THE Money Cost OF PRODUCING WITH SMALLSCALE OR INDUSTRIAL SCALE ENERGY WILL DECREASE, ...
        // EVERYTIME YOU PRESS A "+" BUTTON.
        manualEnergyUpgMoney.multiplier = 0.75f;
        autoEnergyUpgMoney.multiplier = 0.75f;
    }

    public void Migrate()
    {
        migrated = true;
        autoEnergyManager.migrated = true;

        // AFFECT BOTH SMALLSCALE AND INDUSTRIAL SCALE ENERGY PRODUCTION COSTS:
        if (oilWarHappened == false)
        {
            manualEnergyProd.tradeFloat *= 0.8f;
            autoEnergyProd.tradeFloat *= 0.8f;

            // MULTIPLIES THE BASE PRODUCTION COSTS BY THE SMALLSCALE OR INDUSTRIAL SCALE AmountSimple NUMBER... 
            // (THE TIMES IN WHICH SMALL OR IND HAVE BEEN UPGRADED WITH THE "+" BUTTON).
            for (int i = 0; i < manualEnergyUpgAmountSimple.simpleAmount; i++)
            {
                // THIS IS FOR MANUAL (SMALLSCALE)
                theSameTradeElems[0].tradeFloat *= theSameTradeElems[1].multiplier;
                manualMoneyProdCost.tradeFloat *= manualEnergyUpgMoney.multiplier;

            }

            for (int i = 0; i < autoEnergyUpgAmountSimple.simpleAmount; i++)
            {
                // THIS IS FOR AUTO (INDUSTRIAL)
                theSameTradeElems[2].tradeFloat *= theSameTradeElems[3].multiplier;
                autoMoneyProdCost.tradeFloat *= autoEnergyUpgMoney.multiplier;

            }

        }

        // AFFECT BOTH SMALLSCALE AND INDUSTRIAL SCALE ENERGY PRODUCTION COSTS,...
        // AND HEAL THE PUNISHMENT FROM Oil Price Falls CATACLYSM.
        else if (oilWarHappened == true)
        {
            //manualMoneyProdCost.tradeFloat /= catacHealer;
            autoMoneyProdCost.tradeFloat /= catacHealer;
            //manualEnergyProd.tradeFloat *= 0.5f;
            autoEnergyProd.tradeFloat *= 0.8f;
            manualEnergyProd.tradeFloat *= 0.8f;

            // MULTIPLIES THE BASE PRODUCTION COSTS BY THE SMALLSCALE OR INDUSTRIAL SCALE AmountSimple NUMBER... 
            // (THE TIMES IN WHICH SMALL OR IND HAVE BEEN UPGRADED WITH THE "+" BUTTON).
            for (int i = 0; i < manualEnergyUpgAmountSimple.simpleAmount; i++)
            {
                // THIS IS FOR MANUAL (SMALLSCALE)
                theSameTradeElems[0].tradeFloat *= theSameTradeElems[1].multiplier;
                manualMoneyProdCost.tradeFloat *= manualEnergyUpgMoney.multiplier;

            }

            for (int i = 0; i < autoEnergyUpgAmountSimple.simpleAmount; i++)
            {
                // THIS IS FOR AUTO (INDUSTRIAL)
                theSameTradeElems[2].tradeFloat *= theSameTradeElems[3].multiplier;
                autoMoneyProdCost.tradeFloat *= autoEnergyUpgMoney.multiplier;

            }

        }
    }

}
