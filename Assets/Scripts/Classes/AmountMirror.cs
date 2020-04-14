using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmountMirror : MonoBehaviour
{
    public Amount sourceAmount;
    public float amountFloat;
    public TextMeshProUGUI amountTxt;

    public void Update()
    {
        amountTxt.text = amountFloat.ToString("0.0");
        amountFloat = sourceAmount.amountFloat;
        if (amountFloat < 0)
        {
            amountFloat = 0f;
        }
    }

}
