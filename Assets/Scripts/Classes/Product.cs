using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Product : MonoBehaviour
{
    //public float quantityPerClick;
    //public float costPerClick;

    //quantityPerClick *= 1.5; //Exponential
    //quantityPerClick*= (1+Random.value); //Uneven

    //public GameObject prodLockGO; This goes in ProdButton instead.
    public string productName;
    public Amount amountTxt;
    public float quantPerClick;
    public float costPerClick;
    public bool autoIsActive;
    public float quantPerSec;
    public float costPerSec;
    //public TextMeshProUGUI prodAmountTxt; Amount amountTxt already has TMProUGUI and float.

    public void Update()
    {
        amountTxt.amountTxt.text = amountTxt.amountFloat.ToString();
        if (amountTxt.amountFloat < 0f)
        {
            amountTxt.amountFloat = 0f;
        }
    }

}
