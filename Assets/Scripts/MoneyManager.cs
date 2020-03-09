using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public TextMeshProUGUI moneyTMP;
    public TextMeshProUGUI stockTMP;
    public TextMeshProUGUI cargoCapacityTMP;
    public TextMeshProUGUI marketFoodTMP;

    public int moneyAmount = 10;
    public int foodAmount = 0;
    public int cargoAmount = 0;
    public int cargoCapacity = 10;
    public int marketFoodAmount = 0;

    public int moneyPerClick = 1;
    public int foodPerClick = 1;

    public BoatTweener boatTweener;

    public void Start()
    {
        moneyTMP.text = "$" + moneyAmount.ToString();
    }

    public void produceOnClick()
    {
        if (moneyAmount >= 1)
        {
            foodAmount += foodPerClick;
            stockTMP.text = "Stock: " + foodAmount.ToString();

            moneyAmount -= moneyPerClick;
            moneyTMP.text = "$" + moneyAmount.ToString();
        }
        
    }

    public void transportOnClick()
    {
        if (foodAmount + cargoAmount <= cargoCapacity)
        {
            //if (cargoAmount <= cargoCapacity)
            //{
                if (foodAmount >= 1)
                {
                    
                    cargoAmount += foodAmount;
                    cargoCapacityTMP.text = cargoAmount.ToString() + "/" + cargoCapacity.ToString();

                    foodAmount -= foodAmount;
                    stockTMP.text = "Stock: " + foodAmount.ToString();
                    if (cargoAmount == cargoCapacity)
                    {
                        boatTweener.TransportFood();
                        Debug.Log("Boat is sailing!");
                        StartCoroutine(BoatUnloadCoroutine());


                }

                }
            //}
       
        }
        else /*if (foodAmount + cargoAmount > cargoCapacity)*/
        {
            
            if (foodAmount >= 1)
            {
                int foodCargoDifference = (cargoCapacity - cargoAmount);
                Debug.Log(foodCargoDifference);

                cargoAmount += foodCargoDifference;
                cargoCapacityTMP.text = cargoAmount.ToString() + "/" + cargoCapacity.ToString();

                foodAmount -= foodCargoDifference;
                stockTMP.text = "Stock: " + foodAmount.ToString();

                if (cargoAmount == cargoCapacity)
                {
                    boatTweener.TransportFood();
                    Debug.Log("Boat is sailing!");
                    StartCoroutine(BoatUnloadCoroutine());

                }

            }
        }




    }

    IEnumerator BoatUnloadCoroutine()
    {
        yield return new WaitForSeconds(boatTweener.boatSpeed / 1.4f);
        cargoAmount = 0;
        cargoCapacityTMP.text = cargoAmount.ToString() + "/" + cargoCapacity.ToString();
        marketFoodAmount += cargoCapacity;
        marketFoodTMP.text = marketFoodAmount.ToString();

    }


}
