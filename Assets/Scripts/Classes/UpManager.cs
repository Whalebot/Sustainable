using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpManager : MonoBehaviour
{
    public string UpButtName;
    public float[] multipliers;
    public TradeOffDescriptorElem[] tradeOffReqs;
    public float[] storedTradeReq;

    // REFS FOR NEWS EVENT TRIGGERING.
    public Product linkedProduct;
    public bool eventIsPossible;
    public float eventThreshold;
    public GameObject newsHeadline;
    public SeenNews iconWorldObj;

    public void Awake()
    {
        storedTradeReq = new float[tradeOffReqs.Length];

        if (tradeOffReqs.Length == 1)
        {
            storedTradeReq[0] = tradeOffReqs[0].tradeFloat;
        }

        else if (tradeOffReqs.Length == 2)
        {
            storedTradeReq[0] = tradeOffReqs[0].tradeFloat;
            storedTradeReq[1] = tradeOffReqs[1].tradeFloat;

        }

        else if (tradeOffReqs.Length == 3)
        {
            storedTradeReq[0] = tradeOffReqs[0].tradeFloat;
            storedTradeReq[1] = tradeOffReqs[1].tradeFloat;
            storedTradeReq[2] = tradeOffReqs[2].tradeFloat;


        }

        else if (tradeOffReqs.Length == 4)
        {
            storedTradeReq[0] = tradeOffReqs[0].tradeFloat;
            storedTradeReq[1] = tradeOffReqs[1].tradeFloat;
            storedTradeReq[2] = tradeOffReqs[2].tradeFloat;
            storedTradeReq[3] = tradeOffReqs[3].tradeFloat;


        }

        else if (tradeOffReqs.Length == 5)
        {
            storedTradeReq[0] = tradeOffReqs[0].tradeFloat;
            storedTradeReq[1] = tradeOffReqs[1].tradeFloat;
            storedTradeReq[2] = tradeOffReqs[2].tradeFloat;
            storedTradeReq[3] = tradeOffReqs[3].tradeFloat;
            storedTradeReq[4] = tradeOffReqs[4].tradeFloat;


        }
        //else if (tradeOffReqs.Length == 5)
        //{
        //    storedTradeReq[0] = tradeOffReqs[0].tradeFloat;
        //    storedTradeReq[1] = tradeOffReqs[1].tradeFloat;
        //    storedTradeReq[2] = tradeOffReqs[2].tradeFloat;
        //    storedTradeReq[3] = tradeOffReqs[3].tradeFloat;
        //    storedTradeReq[4] = tradeOffReqs[4].tradeFloat;


        //}

        else if (tradeOffReqs.Length == 6)
        {
            storedTradeReq[0] = tradeOffReqs[0].tradeFloat;
            storedTradeReq[1] = tradeOffReqs[1].tradeFloat;
            storedTradeReq[2] = tradeOffReqs[2].tradeFloat;
            storedTradeReq[3] = tradeOffReqs[3].tradeFloat;
            storedTradeReq[4] = tradeOffReqs[4].tradeFloat;
            storedTradeReq[5] = tradeOffReqs[5].tradeFloat;



        }
    }

    public void Update()
    {

        // THIS WILL TRIGGER A NEWS EVENT WHEN CONDITIONS ARE MET.
        if (eventIsPossible == true)
        {
            if (linkedProduct.amountTxt.amountFloat > eventThreshold)
            {
                LinkNews();
            }
        }


        // THIS JUST UPDATES THE VALUES OF TradeOffReq AND storedTradeReq.
        if (tradeOffReqs.Length == 1)
        {
            storedTradeReq[0] = tradeOffReqs[0].tradeFloat;
            tradeOffReqs[0].tradeFloat = storedTradeReq[0];
        }

        else if (tradeOffReqs.Length == 2)
        {
            storedTradeReq[0] = tradeOffReqs[0].tradeFloat;
            tradeOffReqs[0].tradeFloat = storedTradeReq[0];

            storedTradeReq[1] = tradeOffReqs[1].tradeFloat;
            tradeOffReqs[1].tradeFloat = storedTradeReq[1];

        }

        else if (tradeOffReqs.Length == 3)
        {
            storedTradeReq[0] = tradeOffReqs[0].tradeFloat;
            tradeOffReqs[0].tradeFloat = storedTradeReq[0];

            storedTradeReq[1] = tradeOffReqs[1].tradeFloat;
            tradeOffReqs[1].tradeFloat = storedTradeReq[1];

            storedTradeReq[2] = tradeOffReqs[2].tradeFloat;
            tradeOffReqs[2].tradeFloat = storedTradeReq[2];


        }

        else if (tradeOffReqs.Length == 4)
        {
            storedTradeReq[0] = tradeOffReqs[0].tradeFloat;
            tradeOffReqs[0].tradeFloat = storedTradeReq[0];

            storedTradeReq[1] = tradeOffReqs[1].tradeFloat;
            tradeOffReqs[1].tradeFloat = storedTradeReq[1];

            storedTradeReq[2] = tradeOffReqs[2].tradeFloat;
            tradeOffReqs[2].tradeFloat = storedTradeReq[2];

            storedTradeReq[3] = tradeOffReqs[3].tradeFloat;
            tradeOffReqs[3].tradeFloat = storedTradeReq[3];


        }

        else if (tradeOffReqs.Length == 5)
        {
            storedTradeReq[0] = tradeOffReqs[0].tradeFloat;
            tradeOffReqs[0].tradeFloat = storedTradeReq[0];

            storedTradeReq[1] = tradeOffReqs[1].tradeFloat;
            tradeOffReqs[1].tradeFloat = storedTradeReq[1];

            storedTradeReq[2] = tradeOffReqs[2].tradeFloat;
            tradeOffReqs[2].tradeFloat = storedTradeReq[2];

            storedTradeReq[3] = tradeOffReqs[3].tradeFloat;
            tradeOffReqs[3].tradeFloat = storedTradeReq[3];

            storedTradeReq[4] = tradeOffReqs[4].tradeFloat;
            tradeOffReqs[4].tradeFloat = storedTradeReq[4];


        }

        else if (tradeOffReqs.Length == 6)
        {
            storedTradeReq[0] = tradeOffReqs[0].tradeFloat;
            tradeOffReqs[0].tradeFloat = storedTradeReq[0];

            storedTradeReq[1] = tradeOffReqs[1].tradeFloat;
            tradeOffReqs[1].tradeFloat = storedTradeReq[1];

            storedTradeReq[2] = tradeOffReqs[2].tradeFloat;
            tradeOffReqs[2].tradeFloat = storedTradeReq[2];

            storedTradeReq[3] = tradeOffReqs[3].tradeFloat;
            tradeOffReqs[3].tradeFloat = storedTradeReq[3];

            storedTradeReq[4] = tradeOffReqs[4].tradeFloat;
            tradeOffReqs[4].tradeFloat = storedTradeReq[4];

            storedTradeReq[5] = tradeOffReqs[5].tradeFloat;
            tradeOffReqs[5].tradeFloat = storedTradeReq[5];


        }
    }

    public void ExecuteUpgradeMultiply()
    {
        if (tradeOffReqs.Length == 1)
        {
            storedTradeReq[0] *= multipliers[0];
            tradeOffReqs[0].tradeFloat *= multipliers[0];

        }

        else if (tradeOffReqs.Length == 2)
        {
            storedTradeReq[0] *= multipliers[0];
            tradeOffReqs[0].tradeFloat *= multipliers[0];

            storedTradeReq[1] *= multipliers[1];
            tradeOffReqs[1].tradeFloat *= multipliers[1];



        }

        else if (tradeOffReqs.Length == 3)
        {
            storedTradeReq[0] *= multipliers[0];
            tradeOffReqs[0].tradeFloat *= multipliers[0];

            storedTradeReq[1] *= multipliers[1];
            tradeOffReqs[1].tradeFloat *= multipliers[1];


            storedTradeReq[2] *= multipliers[2];
            tradeOffReqs[2].tradeFloat *= multipliers[2];



        }

        else if (tradeOffReqs.Length == 4)
        {
            storedTradeReq[0] *= multipliers[0];
            tradeOffReqs[0].tradeFloat *= multipliers[0];

            storedTradeReq[1] *= multipliers[1];
            tradeOffReqs[1].tradeFloat *= multipliers[1];


            storedTradeReq[2] *= multipliers[2];
            tradeOffReqs[2].tradeFloat *= multipliers[2];


            storedTradeReq[3] *= multipliers[3];
            tradeOffReqs[3].tradeFloat *= multipliers[3];
        }

        else if (tradeOffReqs.Length == 5)
        {
            storedTradeReq[0] *= multipliers[0];
            tradeOffReqs[0].tradeFloat *= multipliers[0];

            storedTradeReq[1] *= multipliers[1];
            tradeOffReqs[1].tradeFloat *= multipliers[1];


            storedTradeReq[2] *= multipliers[2];
            tradeOffReqs[2].tradeFloat *= multipliers[2];


            storedTradeReq[3] *= multipliers[3];
            tradeOffReqs[3].tradeFloat *= multipliers[3];


            storedTradeReq[4] *= multipliers[4];
            tradeOffReqs[4].tradeFloat *= multipliers[4];

        }

        else if (tradeOffReqs.Length == 6)
        {
            storedTradeReq[0] *= multipliers[0];
            tradeOffReqs[0].tradeFloat *= multipliers[0];

            storedTradeReq[1] *= multipliers[1];
            tradeOffReqs[1].tradeFloat *= multipliers[1];


            storedTradeReq[2] *= multipliers[2];
            tradeOffReqs[2].tradeFloat *= multipliers[2];


            storedTradeReq[3] *= multipliers[3];
            tradeOffReqs[3].tradeFloat *= multipliers[3];


            storedTradeReq[4] *= multipliers[4];
            tradeOffReqs[4].tradeFloat *= multipliers[4];


            storedTradeReq[5] *= multipliers[5];
            tradeOffReqs[5].tradeFloat *= multipliers[5];



        }
    }

    // THIS IS TRIGGERED THROUGH UPDATE. CREATES A NEW HEADLINE AND TRIGGERS NOTIFICATION ANIMATION.
    public void LinkNews()
    {
        newsHeadline.gameObject.SetActive(true);
        iconWorldObj.ArrivingNotification();
    }

    // AN UPGRADE BUTTON HAS TO PERFORM THIS METHOD.
    public void EventPossibilizer()
    {
        eventIsPossible = true;
    }

}
