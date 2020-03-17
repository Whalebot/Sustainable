using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ParametersManagement : MonoBehaviour
{
    //Arrays for almost all 23 variables (products, resources, multipliers, or subtractors) of the game.
    public TextMeshProUGUI[] tMPObject; //This is the text that I use to render the quantity of many variables.
    public float[] quantity; //This is the float I use to store the quantity of the different variables.
    //public float[] moneyGained; //This could store the money contributed by each variable.
    public float[] quantityPerClick; //Stores how many units I gain for variables/resources I produce in game.
    public float[] moneyCostPerClick; //Cost of producing units.

    //Values of the blue tabs in the top-center of the screen.
    public TextMeshProUGUI foodProductsTMP;
    public float foodProductsTotal;
    public TextMeshProUGUI energyMatTMP;
    public float energyMatTotal;
    public TextMeshProUGUI wastePollutionTMP;
    public float wastePollutionTotal;
    public TextMeshProUGUI peopleTMP;
    public float peopleTotal;

    //Variables I will use for the Boat 
    public BoatTweener boatTweener;
    public TextMeshProUGUI cargoCapacityTMP;
    public GameObject oneBoat;
    public float cargoAmount = 0;
    public float cargoCapacity = 10;


    //Variables I will use for the Money 
    public TextMeshProUGUI moneyTMP;
    public float moneyAmount = 10;


    public void Start()
    {
        oneBoat.gameObject.SetActive(false);
        moneyTMP.text = "$" + moneyAmount.ToString("0.00");
    }

    //Functioned to create Boats on button click.
    public void produce0()
    {
        if (moneyAmount >= 1)
        {
            quantityPerClick[0] = 1;
            moneyCostPerClick[0] = 5;
            quantity[0] += quantityPerClick[0];
            tMPObject[0].text = quantity[0].ToString();

            moneyAmount -= moneyCostPerClick[0];
            moneyTMP.text = "$" + moneyAmount.ToString("0.00");

            oneBoat.gameObject.SetActive(true);
        }
    }

    //Function to create Livestock on button click.
    public void produce1()
    {
        if (moneyAmount >= 1)
        {
            quantityPerClick[1] = 2;
            moneyCostPerClick[1] = 1;
            quantity[1] += quantityPerClick[1];
            tMPObject[1].text = quantity[1].ToString("0");

            if (quantity[0] > 0)
            {
                moneyAmount -= moneyCostPerClick[1];
                moneyTMP.text = "$" + moneyAmount.ToString("0.00");
            }
        }
    }

    //Function to create Organic Waste on button click (for testing).
    //public void produce12()
    //{
    //    if (moneyAmount >= 1)
    //    {
    //        quantityPerClick[12] = 2;
    //        moneyCostPerClick[12] = 1;
    //        quantity[12] += quantityPerClick[12];
    //        tMPObject[12].text = quantity[12].ToString("0");

    //    }
    //}

    //Function to create Plastic Waste on button click (for testing).
    //public void produce13()
    //{
    //    if (moneyAmount >= 1)
    //    {
    //        quantityPerClick[13] = 2;
    //        moneyCostPerClick[13] = 1;
    //        quantity[13] += quantityPerClick[13];
    //        tMPObject[13].text = quantity[13].ToString("0");

    //    }
    //}


    public void Update()
    {
        //Updates the total amount of food created/available.
        foodProductsTotal = quantity[1] + quantity[2] + quantity[3] + quantity[4] + quantity[5];
        foodProductsTMP.text = foodProductsTotal.ToString("0");

        //Updates the total amount of waste created/available.
        wastePollutionTotal = quantity[12] + quantity[13] + quantity[14] + quantity[15] + quantity[16];
        wastePollutionTMP.text = wastePollutionTotal.ToString("0");


        //Updates the outcomes of Livestock, which people consume and generate waste.
        if (quantity[1] >= 0.1)
        {
            tMPObject[1].text = quantity[1].ToString("0");
            quantity[1] -= 1f * Time.deltaTime * quantity[0];

            moneyTMP.text = "$" + moneyAmount.ToString("0.00");
            moneyAmount += 2f * Time.deltaTime * quantity[0];

            tMPObject[12].text = quantity[12].ToString("0");
            quantity[12] += 0.5f * Time.deltaTime * quantity[0];

            tMPObject[13].text = quantity[13].ToString("0");
            quantity[13] += 1f * Time.deltaTime * quantity[0];


        }

        //Updates outcomes of Organic Waste, producing Gas Emissions.
        if (quantity[12] >= 0.1)
        {
            tMPObject[14].text = quantity[14].ToString("0");
            quantity[14] += 0.1f * Time.deltaTime;
        }

       

    }

   

}
