using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolicyManager : MonoBehaviour
{
    public bool upgradeIsPending;
    public GameObject root;


    // ONLY USE ONE BOOL PER MANAGER. IF THERE'S ONLY ONE TYPE OF ELEMENT, usesOneType. IF THERE'S ONLY TWO TYPES, usesTwoTypes, ETC.
    // NOTE: TYPES OF TYPES: ECONOMY, FOOD, WASTE, POLLUTION, ETC. DO NOT MIX.
    public bool usesOneType;
    public bool typeOneIsAuto;
    public bool switchesIsAdditiveOne;
    public float multiplier1;
    //public GameObject type1Root;
    public TradeOffDescriptorElem[] elemType1;

    public bool usesTwoTypes;
    public bool typeTwoIsAuto;
    public bool switchesIsAdditiveTwo;
    public float multiplier2;
    //public GameObject type2Root;
    public TradeOffDescriptorElem[] elemType2;

    public bool usesThreeTypes;
    public bool typeThreeIsAuto;
    public bool switchesIsAdditiveThree;
    public float multiplier3;
    //public GameObject type3Root;
    public TradeOffDescriptorElem[] elemType3;

    public void Start()
    {
        upgradeIsPending = false;
    }

    public void Schedule()
    {
        upgradeIsPending = true;
    }

    public void Update()
    {
        if (upgradeIsPending == true)
        {

            if (usesOneType == true)
            {

                if (root.activeInHierarchy == true)
                {
                    for (int i = 0; i < elemType1.Length; i++)
                    {
                        if (typeOneIsAuto == false)
                        {
                            if (switchesIsAdditiveOne == false)
                            {
                                elemType1[i].tradeFloat *= multiplier1;
                            }
                            else if (switchesIsAdditiveOne == true)
                            {
                                elemType1[i].tradeFloat *= multiplier1;
                                elemType1[i].isAdditive = !elemType1[i].isAdditive;
                            }
                        }
                        else if (typeOneIsAuto == true)
                        {
                            if (switchesIsAdditiveOne == false)
                            {
                                elemType1[i].autoFloat *= multiplier1;
                            }
                            else if (switchesIsAdditiveOne == true)
                            {
                                elemType1[i].autoFloat *= multiplier1;
                                elemType1[i].isAdditive = !elemType1[i].isAdditive;
                            }
                        }
                        //}


                    }

                    // WE NEED TO TURN OFF upgradeIsPending, SO THAT THE MULTIPLICATION ONLY HAPPENS ONCE DURING UPDATE.
                    upgradeIsPending = false;
                }

                

            }

            else if (usesTwoTypes == true)
            {

                if (root.activeInHierarchy == true)
                {
                    for (int i = 0; i < elemType1.Length; i++)
                    {
                        //if (type1Root.activeInHierarchy == true)
                        //{
                        if (typeOneIsAuto == false)
                        {
                            if (switchesIsAdditiveOne == false)
                            {
                                elemType1[i].tradeFloat *= multiplier1;
                            }
                            else if (switchesIsAdditiveOne == true)
                            {
                                elemType1[i].tradeFloat *= multiplier1;
                                elemType1[i].isAdditive = !elemType1[i].isAdditive;
                            }
                        }
                        else if (typeOneIsAuto == true)
                        {
                            if (switchesIsAdditiveOne == false)
                            {
                                elemType1[i].autoFloat *= multiplier1;
                            }
                            else if (switchesIsAdditiveOne == true)
                            {
                                elemType1[i].autoFloat *= multiplier1;
                                elemType1[i].isAdditive = !elemType1[i].isAdditive;
                            }
                        }
                        //}
                    }

                    for (int i = 0; i < elemType2.Length; i++)
                    {
                        if (typeTwoIsAuto == false)
                        {
                            if (switchesIsAdditiveTwo == false)
                            {
                                elemType2[i].tradeFloat *= multiplier2;
                            }
                            else if (switchesIsAdditiveTwo == true)
                            {
                                elemType2[i].tradeFloat *= multiplier2;
                                elemType2[i].isAdditive = !elemType2[i].isAdditive;
                            }
                        }
                        else if (typeTwoIsAuto == true)
                        {
                            if (switchesIsAdditiveTwo == false)
                            {
                                elemType2[i].autoFloat *= multiplier2;
                            }
                            else if (switchesIsAdditiveTwo == true)
                            {
                                elemType2[i].autoFloat *= multiplier2;
                                elemType2[i].isAdditive = !elemType2[i].isAdditive;
                            }
                        }

                        //if (typeTwoIsAuto == false)
                        //{
                        //    elemType2[i].tradeFloat *= multiplier2;
                        //}
                        //else if (typeTwoIsAuto == true)
                        //{
                        //    elemType2[i].autoFloat *= multiplier2;
                        //}
                    }

                    // WE NEED TO TURN OFF upgradeIsPending, SO THAT THE MULTIPLICATION ONLY HAPPENS ONCE DURING UPDATE.
                    upgradeIsPending = false;
                }

                    

            }

            else if (usesThreeTypes == true)
            {
                if (root.activeInHierarchy == true)
                {
                    for (int i = 0; i < elemType1.Length; i++)
                    {
                        if (typeOneIsAuto == false)
                        {
                            if (switchesIsAdditiveOne == false)
                            {
                                elemType1[i].tradeFloat *= multiplier1;
                            }
                            else if (switchesIsAdditiveOne == true)
                            {
                                elemType1[i].tradeFloat *= multiplier1;
                                elemType1[i].isAdditive = !elemType1[i].isAdditive;
                            }
                        }
                        else if (typeOneIsAuto == true)
                        {
                            if (switchesIsAdditiveOne == false)
                            {
                                elemType1[i].autoFloat *= multiplier1;
                            }
                            else if (switchesIsAdditiveOne == true)
                            {
                                elemType1[i].autoFloat *= multiplier1;
                                elemType1[i].isAdditive = !elemType1[i].isAdditive;
                            }
                        }
                    }

                    for (int i = 0; i < elemType2.Length; i++)
                    {
                        if (typeTwoIsAuto == false)
                        {
                            if (switchesIsAdditiveTwo == false)
                            {
                                elemType2[i].tradeFloat *= multiplier2;
                            }
                            else if (switchesIsAdditiveTwo == true)
                            {
                                elemType2[i].tradeFloat *= multiplier2;
                                elemType2[i].isAdditive = !elemType2[i].isAdditive;
                            }
                        }
                        else if (typeTwoIsAuto == true)
                        {
                            if (switchesIsAdditiveTwo == false)
                            {
                                elemType2[i].autoFloat *= multiplier2;
                            }
                            else if (switchesIsAdditiveTwo == true)
                            {
                                elemType2[i].autoFloat *= multiplier2;
                                elemType2[i].isAdditive = !elemType2[i].isAdditive;
                            }
                        }
                    }

                    for (int i = 0; i < elemType3.Length; i++)
                    {
                        if (typeThreeIsAuto == false)
                        {
                            if (switchesIsAdditiveThree == false)
                            {
                                elemType3[i].tradeFloat *= multiplier3;
                            }
                            else if (switchesIsAdditiveThree == true)
                            {
                                elemType3[i].tradeFloat *= multiplier3;
                                elemType3[i].isAdditive = !elemType3[i].isAdditive;
                            }
                        }
                        else if (typeThreeIsAuto == true)
                        {
                            if (switchesIsAdditiveThree == false)
                            {
                                elemType3[i].autoFloat *= multiplier3;
                            }
                            else if (switchesIsAdditiveThree == true)
                            {
                                elemType3[i].autoFloat *= multiplier3;
                                elemType3[i].isAdditive = !elemType3[i].isAdditive;
                            }
                        }

                        //if (typeThreeIsAuto == false)
                        //{
                        //    elemType3[i].tradeFloat *= multiplier3;
                        //}
                        //else if (typeThreeIsAuto == true)
                        //{
                        //    elemType3[i].autoFloat *= multiplier3;
                        //}
                    }

                    // WE NEED TO TURN OFF upgradeIsPending, SO THAT THE MULTIPLICATION ONLY HAPPENS ONCE DURING UPDATE.
                    upgradeIsPending = false;
                }

                

            }
        }
    }

}
