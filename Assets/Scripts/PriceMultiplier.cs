using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriceMultiplier : MonoBehaviour
{
    //public AmountSimple simpleAmount;
    public float multip;
    public TradeOffDescriptorElem tradeOffElementum;
    //public bool isSimple;
    //public bool isElementum;

    

    public void ApplyMultiplication()
    {
        //if (isSimple == true)
        //{
        //    simpleAmount.simpleAmount *= multip;
        //}
        //else if (isElementum == true)
        //{
            tradeOffElementum.tradeFloat *= multip;
        //}
    }
}
