using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisruptionManager : MonoBehaviour
{
    //public float adder;
    //public bool adds;
    //public bool rests;

    public TradeOffElemsActivator specialOilMigrationUpButton;
    public bool usesSpecialOilMigration;

    public bool specialIsAlgae;
    public AutoAlgae autoAlgae;

    public float multiplier;
    public bool multiplies;
    public bool divides;

    public Amount[] resOrProdUp;
    public Amount[] resOrProdDown;
    public bool affectsResOrProd;

    public TradeOffDescriptorElem[] tradeOffUp;
    public TradeOffDescriptorElem[] tradeOffDown;
    public bool affectsTradeOff;
    public bool affectsTradeOffSpecial;


    public GameObject failedWin;
    public GameObject succWin;
    
    public void ApplyDisruption()
    {
        float random = (Random.Range(-1f, 1f));
        Debug.Log(random);
        

        if (affectsResOrProd == true)
        {
            //if (multiplies == true && divides == false)
            //{
            //    for (int i = 0; i < resOrProdUp.Length; i++)
            //    {
            //        resOrProdUp[i].amountFloat *= multiplier;
            //    }
            //}
            //else if (multiplies == false && divides == true)
            //{
            //    for (int i = 0; i < resOrProdDown.Length; i++)
            //    {
            //        resOrProdDown[i].amountFloat *= multiplier;
            //    }
            //}
            //else if (multiplies == true && divides == true)
            //{
            //    for (int i = 0; i < resOrProdUp.Length; i++)
            //    {
            //        resOrProdUp[i].amountFloat *= multiplier;
            //    }

            //    for (int i = 0; i < resOrProdDown.Length; i++)
            //    {
            //        resOrProdDown[i].amountFloat /= multiplier;
            //    }
            //}

            if (random < 0) // PREVENTED
            {
                if (multiplies == true && divides == false)
                {
                    for (int i = 0; i < resOrProdUp.Length; i++)
                    {
                        resOrProdUp[i].amountFloat *= 1.1f;
                        succWin.gameObject.SetActive(true);
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
            else if (random >= 0) // CATASTROPHE
            {
                if (multiplies == true && divides == false)
                {
                    for (int i = 0; i < resOrProdUp.Length; i++)
                    {
                        resOrProdUp[i].amountFloat *= multiplier;
                        failedWin.gameObject.SetActive(true);
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

        }

        else if (affectsTradeOff == true)
        {
            if (random < 0) // PREVENTED
            {
                if (multiplies == true && divides == false)
                {
                    for (int i = 0; i < tradeOffUp.Length; i++)
                    {
                        tradeOffUp[i].tradeFloat *= 1.1f;
                        succWin.gameObject.SetActive(true);
                    }
                }
                else if (multiplies == false && divides == true)
                {
                    for (int i = 0; i < tradeOffDown.Length; i++)
                    {
                        tradeOffDown[i].tradeFloat *= 0.9f;
                        succWin.gameObject.SetActive(true);

                    }
                }
                else if (multiplies == true && divides == true)
                {
                    for (int i = 0; i < tradeOffUp.Length; i++)
                    {
                        tradeOffUp[i].tradeFloat *= 1.1f;
                    }

                    for (int i = 0; i < tradeOffDown.Length; i++)
                    {
                        tradeOffDown[i].tradeFloat /= 1;
                    }
                }


            }
            else if (random >= 0) // CATASTROPHE
            {
                if (multiplies == true && divides == false)
                {
                    for (int i = 0; i < tradeOffUp.Length; i++)
                    {
                        tradeOffUp[i].tradeFloat *= multiplier;
                        failedWin.gameObject.SetActive(true);

                    }
                }
                else if (multiplies == false && divides == true)
                {
                    if (usesSpecialOilMigration == true)
                    {
                        specialOilMigrationUpButton.oilWarActivator();
                    }
                    for (int i = 0; i < tradeOffDown.Length; i++)
                    {
                        tradeOffDown[i].tradeFloat *= multiplier;
                        failedWin.gameObject.SetActive(true);

                    }
                }
                else if (multiplies == true && divides == true)
                {
                    for (int i = 0; i < tradeOffUp.Length; i++)
                    {
                        tradeOffUp[i].tradeFloat *= multiplier;
                        failedWin.gameObject.SetActive(true);

                    }

                    for (int i = 0; i < tradeOffDown.Length; i++)
                    {
                        tradeOffDown[i].tradeFloat /= multiplier;
                    }
                }


            }

            
        }

        else if (affectsTradeOffSpecial == true)
        {
            if (random < 0) // PREVENTED
            {
                if (multiplies == true && divides == false)
                {
                    for (int i = 0; i < tradeOffUp.Length; i++)
                    {
                        tradeOffUp[i].tradeFloat *= 1.1f;
                        succWin.gameObject.SetActive(true);
                    }
                }
                else if (multiplies == false && divides == true)
                {
                    for (int i = 0; i < tradeOffDown.Length; i++)
                    {
                        tradeOffDown[i].tradeFloat *= 1f;
                    }
                }
                else if (multiplies == true && divides == true)
                {
                    for (int i = 0; i < tradeOffUp.Length; i++)
                    {
                        tradeOffUp[i].tradeFloat *= 1.1f;
                    }

                    for (int i = 0; i < tradeOffDown.Length; i++)
                    {
                        tradeOffDown[i].tradeFloat /= 1;
                    }
                }


            }
            else if (random >= 0) // CATASTROPHE
            {
                if (multiplies == true && divides == false)
                {
                    for (int i = 0; i < tradeOffDown.Length; i++)
                    {
                        autoAlgae.usesCataclysm = true;
                        tradeOffDown[i].isAdditive = true;
                        failedWin.gameObject.SetActive(true);

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
                        failedWin.gameObject.SetActive(true);

                    }

                    for (int i = 0; i < tradeOffDown.Length; i++)
                    {
                        tradeOffDown[i].tradeFloat /= multiplier;
                    }
                }


            }


        }

    }



}
