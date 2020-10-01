using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class SmallScaleLimitManager : MonoBehaviour
{
    public bool isAi;
    public AmountSimple amountSimple;
    public float limit;
    public GameObject limitButtonOff;

    // Update is called once per frame
    public void CheckLimit()
    {
        if (isAi == false)
        {
            if (amountSimple.simpleAmount >= limit)
            {
                limitButtonOff.gameObject.SetActive(true);
            }
        }
       
    }
}
