using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpManager : MonoBehaviour
{
    public string UpButtName;
    public float[] multipliers;
    public TradeOffDescriptorElem[] tradeOffReqs;

    public void Update()
    {
        if (tradeOffReqs.Length == 1)
        {
            tradeOffReqs[0].tradeFloat = tradeOffReqs[0].tradeFloat;
        }

        else if (tradeOffReqs.Length == 2)
        {
            tradeOffReqs[0].tradeFloat = tradeOffReqs[0].tradeFloat;
            tradeOffReqs[1].tradeFloat = tradeOffReqs[1].tradeFloat;

        }

        else if (tradeOffReqs.Length == 3)
        {
            tradeOffReqs[0].tradeFloat = tradeOffReqs[0].tradeFloat;
            tradeOffReqs[1].tradeFloat = tradeOffReqs[1].tradeFloat;
            tradeOffReqs[2].tradeFloat = tradeOffReqs[2].tradeFloat;


        }

        else if (tradeOffReqs.Length == 4)
        {
            tradeOffReqs[0].tradeFloat = tradeOffReqs[0].tradeFloat;
            tradeOffReqs[1].tradeFloat = tradeOffReqs[1].tradeFloat;
            tradeOffReqs[2].tradeFloat = tradeOffReqs[2].tradeFloat;
            tradeOffReqs[3].tradeFloat = tradeOffReqs[3].tradeFloat;


        }

        else if (tradeOffReqs.Length == 5)
        {
            tradeOffReqs[0].tradeFloat = tradeOffReqs[0].tradeFloat;
            tradeOffReqs[1].tradeFloat = tradeOffReqs[1].tradeFloat;
            tradeOffReqs[2].tradeFloat = tradeOffReqs[2].tradeFloat;
            tradeOffReqs[3].tradeFloat = tradeOffReqs[3].tradeFloat;
            tradeOffReqs[4].tradeFloat = tradeOffReqs[4].tradeFloat;


        }
    }

    public void ExecuteUpgradeMultiply()
    {
        if (tradeOffReqs.Length == 1)
        {
            tradeOffReqs[0].tradeFloat *= multipliers[0]; 
        }

        else if (tradeOffReqs.Length == 2)
        {
            tradeOffReqs[0].tradeFloat *= multipliers[0];
            tradeOffReqs[1].tradeFloat *= multipliers[1];

        }

        else if (tradeOffReqs.Length == 3)
        {
            tradeOffReqs[0].tradeFloat *= multipliers[0];
            tradeOffReqs[1].tradeFloat *= multipliers[1];
            tradeOffReqs[2].tradeFloat *= multipliers[2];


        }

        else if (tradeOffReqs.Length == 4)
        {
            tradeOffReqs[0].tradeFloat *= multipliers[0];
            tradeOffReqs[1].tradeFloat *= multipliers[1];
            tradeOffReqs[2].tradeFloat *= multipliers[2];
            tradeOffReqs[3].tradeFloat *= multipliers[3];

        }

        else if (tradeOffReqs.Length == 5)
        {
            tradeOffReqs[0].tradeFloat *= multipliers[0];
            tradeOffReqs[1].tradeFloat *= multipliers[1];
            tradeOffReqs[2].tradeFloat *= multipliers[2];
            tradeOffReqs[3].tradeFloat *= multipliers[3];
            tradeOffReqs[4].tradeFloat *= multipliers[4];

        }
    }

}
