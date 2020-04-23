using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_DescriptorElem : MonoBehaviour
{
    public Test_Amount amount;
    public float numberToAdd;

    public void Add()
    {
        //amount = new Test_Amount();
        amount.amountCurrent += numberToAdd;
    }

    public void Subtract()
    {
        //amount = new Test_Amount();
        amount.amountCurrent -= numberToAdd;
    }
}

