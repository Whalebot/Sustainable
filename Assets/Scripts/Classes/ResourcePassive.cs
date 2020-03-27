using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcePassive : MonoBehaviour
{
    public Amount resourceCurrent; // Has data about current resource status.
    public float mileExponent;

    public bool isEconomy;
    public bool isSocial;
    public bool isWaste;
    

    

    public void Update()
    {
        if (isEconomy == true)
        {
            resourceCurrent.amountTxt.text = resourceCurrent.amountFloat.ToString("0.00"); //Updates Resource amount. Two decimals for money.

        }
        else if (isSocial == true)
        {
            resourceCurrent.amountTxt.text = resourceCurrent.amountFloat.ToString("0"); //Updates Resource amount. No decimals.

        }
        else if (isWaste == true)
        {
            resourceCurrent.amountTxt.text = resourceCurrent.amountFloat.ToString("0.0"); //Updates Resource amount. One decimal.

        }
    }
}
