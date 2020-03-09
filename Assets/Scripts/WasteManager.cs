using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WasteManager : MonoBehaviour
{
    public TextMeshProUGUI wasteTMP;
    public float wasteAmount = 0f;
    public MarketFoodManager marketFoodManager;
    public MoneyManager moneyManager;

    public void Update()
    {
        if (moneyManager.marketFoodAmount >= 0.1)
        {
            //moneyManager.marketFoodAmount -= 1f * Time.deltaTime;
            //moneyManager.marketFoodTMP.text = moneyManager.marketFoodAmount.ToString();

            wasteAmount += 1f * Time.deltaTime;
            wasteTMP.text = wasteAmount.ToString();

        }

    }

    //public void UpdateWaste()
    //{
    //    wasteTMP.text = wasteAmount.ToString();

    //}

}
