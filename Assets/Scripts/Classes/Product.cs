using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Product : MonoBehaviour
{
    public string productName;
    public Amount amountTxt;
    public float quantPerClick;
    public float costPerClick;
    public bool autoIsActive;
    public float quantPerSec;
    public float costPerSec;

    public void Update()
    {
        amountTxt.amountTxt.text = amountTxt.amountFloat.ToString();
        if (amountTxt.amountFloat < 0f)
        {
            amountTxt.amountFloat = 0f;
        }
    }

}
