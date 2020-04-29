using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisruptionManager : MonoBehaviour
{
    //public float adder;
    //public bool adds;
    //public bool rests;

    public float multiplier;
    public bool multiplies;
    public bool divides;

    public Amount[] resOrProdUp;
    public Amount[] resOrProdDown;
    public bool affectsResOrProd;

    public TradeOffDescriptorElem[] tradeOffUp;
    public TradeOffDescriptorElem[] tradeOffDown;
    public bool affectsTradeOff;
    
    public void ApplyDisruption()
    {
        if (affectsResOrProd == true)
        {
            if (multiplies == true && divides == false)
            {
                for (int i = 0; i < resOrProdUp.Length; i++)
                {
                    resOrProdUp[i].amountFloat *= multiplier;
                }
            }
            else if (multiplies == false && divides == true)
            {
                for (int i = 0; i < resOrProdDown.Length; i++)
                {
                    resOrProdDown[i].amountFloat *= multiplier;
                }
            }
            else if (multiplies == true && divides == true)
            {
                for (int i = 0; i < resOrProdUp.Length; i++)
                {
                    resOrProdUp[i].amountFloat *= multiplier;
                }

                for (int i = 0; i < resOrProdDown.Length; i++)
                {
                    resOrProdDown[i].amountFloat /= multiplier;
                }
            }
        }

        else if (affectsTradeOff == true)
        {
            if (multiplies == true && divides == false)
            {
                for (int i = 0; i < tradeOffUp.Length; i++)
                {
                    tradeOffUp[i].tradeFloat *= multiplier;
                }
            }
            else if (multiplies == false && divides == true)
            {
                for (int i = 0; i < tradeOffDown.Length; i++)
                {
                    tradeOffDown[i].tradeFloat *= multiplier;
                }
            }
            else if (multiplies == true && divides == true)
            {
                for (int i = 0; i < tradeOffUp.Length; i++)
                {
                    tradeOffUp[i].tradeFloat *= multiplier;
                }

                for (int i = 0; i < tradeOffDown.Length; i++)
                {
                    tradeOffDown[i].tradeFloat /= multiplier;
                }
            }
        }
        
    }

    

}
