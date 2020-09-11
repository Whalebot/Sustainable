using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmountMirror : MonoBehaviour
{
    // THIS SCRIPT WAS BEING USED BY Canvas (header list), 
    // LINKING THE OBJECTS IN header list WITH THE GAMEOBJECTS CALLED Amount
    // INSIDE THE TradeOff Windows Buttons.

    public Amount sourceAmount;
    public float amountFloat;
    public TextMeshProUGUI amountTxt;

    

    //public void Update()
    //{
    //    amountTxt.text = amountFloat.ToString("0.0");
    //    amountFloat = sourceAmount.amountFloat;
    //    if (amountFloat < 0)
    //    {
    //        amountFloat = 0f;
    //    }
    //}

}
