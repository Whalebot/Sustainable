using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MarketFoodManager : MonoBehaviour
{
    public MoneyManager moneyManager;
    //public TextMeshProUGUI marketFoodTMP;
    //public float marketFoodSubtractor = 1;

    

    public void Update()
    {
        if (moneyManager.marketFoodAmount >= 0.1)
        {
            moneyManager.marketFoodTMP.text = moneyManager.marketFoodAmount.ToString("0");
            moneyManager.marketFoodAmount -= 1f * Time.deltaTime;
            //moneyManager.marketFoodAmount = Mathf.Round(moneyManager.marketFoodAmount * 1.0f) * 0.1f;
            //moneyManager.marketFoodAmount = Mathf.RoundToInt(moneyManager.marketFoodAmount);

            moneyManager.moneyTMP.text = "$" + moneyManager.moneyAmount.ToString("0.00");
            moneyManager.moneyAmount += 2f * Time.deltaTime;
            //moneyManager.moneyAmount = Mathf.RoundToInt(moneyManager.moneyAmount);

        }

    }

}
