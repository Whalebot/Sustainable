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
        energyManualUpgButt.text = newManualName;
        energyAutoUpgButt.text = newAutoName;
    }

    public void InvertUnused()
    {
        for (int i = 0; i < theSameTradeElems.Length; i++)
        {
            theSameTradeElems[i].isUnused = false;
            theSameTradeElems[i].isOpaque = false;

        }

        manualEnergyUpgMoney.multiplier = 0.75f;
        autoEnergyUpgMoney.multiplier = 0.75f;
    }

    public void Migrate()
    {
        migrated = true;
        autoEnergyManager.migrated = true;

        if (oilWarHappened == false)
        {
            manualEnergyProd.tradeFloat *= 0.5f;
            autoEnergyProd.tradeFloat *= 0.5f;

        }

        else if (oilWarHappened == true)
        {
            //manualMoneyProdCost.tradeFloat /= catacHealer;
            autoMoneyProdCost.tradeFloat /= catacHealer;
            //manualEnergyProd.tradeFloat *= 0.5f;
            autoEnergyProd.tradeFloat *= 0.5f;
        }
    }

}
