using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TradeOffDescriptor : MonoBehaviour
{
    //public bool bWEF;
    //public BoatAnimation boatWasteEnerFood;
    //public bool bEC;
    //public BoatEnergyCity boatEnerCity;
    //public bool bF;
    //public BoatFoodCity boatFood;
    //public bool bWC;
    //public BoatWastCity boatWasteCity;
    public bool isAutomatorWithBoat;
    public Button[] automatorOffButton;

    // END OF BOAT REFS.

    public bool buttonsUseMiniTabs;
    public GameObject buttonsPanel;
    public GameObject descriptorWindowPanel;
    public bool elemIsAmountless;
    public ProdButton productButton;
    public GameObject[] prodOffButtons;
    //public GameObject prodButtDiv;
    //public List<GameObject> prodOffButts = new List<GameObject>();
    public UiInfoHoverer prodButtUiInfoHoverer;
    public bool isPerSec;
    //public GameObject descrLockDiv;

    //public List<UpgradeDescriptorElem> Requirements = new List<UpgradeDescriptorElem>(); I need array.length, which I cannot get with this list...
    public string reqWarning = "Max requirements.length should be 5.";
    public TradeOffDescriptorElem[] requirements; //Right now, this should only hold 4 requirements.
    //public int requirementsMet; //Using bools instead.
    public bool[] requirementIsChecked;

    //public GameObject purchased;
    //public bool upIsPurchased;

    //public TextMeshProUGUI benefit;
    //public bool unlocks;
    //public bool increases;
    //public bool decreases;
    //public bool justNeedsUnlockOnce;
    //public string verb;
    //public Upgrade upName;
    public string prodName;
    //public string byHowMuch;
    //public string perWhat;
    //public bool perClick;
    //public bool perSec;
    public bool isAuto;

    // END OF REFERENCES //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



    public void MultiplyAutoFloat()
    {
        for (int i = 0; i < requirements.Length; i++)
        {
            requirements[i].autoFloat *= requirements[i].multiplier;
            //requirements[i].ExecuteAutoTrade(); // DOES NOT EXECUTE EXECUTEAUTOTRADE().
        }
    }

    public void DivideAutoFloat()
    {
        if (productButton.multipliersPurchased > 0)
        {
            for (int i = 0; i < requirements.Length; i++)
            {
                requirements[i].autoFloat /= requirements[i].multiplier;
                //requirements[i].ExecuteAutoTrade(); // DOES NOT EXECUTE EXECUTEAUTOTRADE().
            }
        }
        
    }

    public void Start()
    {

        

        for (int i = 0; i < prodOffButtons.Length; i++)
        {
            prodOffButtons[i].gameObject.SetActive(false);
            //Debug.Log("Im deactivating prodoffbuttons");
        }
        requirementIsChecked = new bool[requirements.Length];
    }

    public void equalizeAutoFloat()
    {
        for (int i = 0; i < requirements.Length; i++)
        {
            requirements[i].autoFloat = requirements[i].originalAutoFloat;
            //requirements[i].ExecuteAutoTrade(); // DOES NOT EXECUTE EXECUTEAUTOTRADE().
        }
    }

    public void ExecuteElementsAuto()
    {
        //Debug.Log("Should be performing ExecuteElementsAuto() in within TradeDescriptor");


        if (isAuto == true)
        {
            Debug.Log("isAuto is " + isAuto);

            if (requirements[0].isAutopurchasable == false)
            {
                isPerSec = false;

                if (isAutomatorWithBoat == true)
                {
                    for (int i = 0; i < automatorOffButton.Length; i++)
                    {
                        automatorOffButton[i].onClick.Invoke();
                    }
                }
                

                //for (int i = 0; i < requirements.Length; i++)
                //{
                //    //requirements[i].isAutomated = true; // DEPRECATED.
                //    //requirements[i].ExecuteAutoTrade(); // DOES NOT EXECUTE EXECUTEAUTOTRADE().
                //}

                //if (bWEF == true && bWC == true)
                //{
                //    boatWasteEnerFood.boatIsSailing = false;
                //}

                //else if (bF == true)
                //    {
                //        boatFood.boatIsSailing = false;

                //    }

                //    else if (bEC == true)
                //    {
                //        boatEnerCity.boatIsSailing = false;

                //    }

            }

            else if (requirements[1].isAutopurchasable == false)
            {
                isPerSec = false;

                if (isAutomatorWithBoat == true)
                {
                    for (int i = 0; i < automatorOffButton.Length; i++)
                    {
                        automatorOffButton[i].onClick.Invoke();
                    }
                }

                //for (int i = 0; i < requirements.Length; i++)
                //{
                //    requirements[i].isAutomated = true;
                //    //requirements[i].ExecuteAutoTrade(); // DOES NOT EXECUTE EXECUTEAUTOTRADE().
                //}

                //if (bWEF == true && bWC == true)
                //{
                //    boatWasteEnerFood.boatIsSailing = false;
                //}

                //else if (bF == true)
                //{
                //    boatFood.boatIsSailing = false;

                //}

                //else if (bEC == true)
                //{
                //    boatEnerCity.boatIsSailing = false;

                //}

            }

            else if (requirements[2].isAutopurchasable == false)
            {
                isPerSec = false;

                if (isAutomatorWithBoat == true)
                {
                    for (int i = 0; i < automatorOffButton.Length; i++)
                    {
                        automatorOffButton[i].onClick.Invoke();
                    }
                }

                //for (int i = 0; i < requirements.Length; i++)
                //{
                //    requirements[i].isAutomated = true;
                //    //requirements[i].ExecuteAutoTrade(); // DOES NOT EXECUTE EXECUTEAUTOTRADE().
                //}

                //if (bWEF == true && bWC == true)
                //{
                //    boatWasteEnerFood.boatIsSailing = false;
                //}

                //else if (bF == true)
                //{
                //    boatFood.boatIsSailing = false;

                //}

                //else if (bEC == true)
                //{
                //    boatEnerCity.boatIsSailing = false;

                //}

            }

            else if (requirements[3].isAutopurchasable == false)
            {
                isPerSec = false;

                if (isAutomatorWithBoat == true)
                {
                    for (int i = 0; i < automatorOffButton.Length; i++)
                    {
                        automatorOffButton[i].onClick.Invoke();
                    }
                }

                //for (int i = 0; i < requirements.Length; i++)
                //{
                //    requirements[i].isAutomated = true;
                //    //requirements[i].ExecuteAutoTrade(); // DOES NOT EXECUTE EXECUTEAUTOTRADE().
                //}

                //if (bWEF == true && bWC == true)
                //{
                //    boatWasteEnerFood.boatIsSailing = false;
                //}

                //else if (bF == true)
                //{
                //    boatFood.boatIsSailing = false;

                //}

                //else if (bEC == true)
                //{
                //    boatEnerCity.boatIsSailing = false;

                //}

            }

            else if (requirements[4].isAutopurchasable == false)
            {
                isPerSec = false;

                if (isAutomatorWithBoat == true)
                {
                    for (int i = 0; i < automatorOffButton.Length; i++)
                    {
                        automatorOffButton[i].onClick.Invoke();
                    }
                }

                //for (int i = 0; i < requirements.Length; i++)
                //{
                //    requirements[i].isAutomated = true;
                //    //requirements[i].ExecuteAutoTrade(); // DOES NOT EXECUTE EXECUTEAUTOTRADE().
                //}

                //if (bWEF == true && bWC == true)
                //{
                //    boatWasteEnerFood.boatIsSailing = false;
                //}



                //else if (bF == true)
                //{
                //    boatFood.boatIsSailing = false;

                //}

                //else if (bEC == true)
                //{
                //    boatEnerCity.boatIsSailing = false;

                //}

            }

            else if (requirements[5].isAutopurchasable == false)
            {
                isPerSec = false;

                if (isAutomatorWithBoat == true)
                {
                    for (int i = 0; i < automatorOffButton.Length; i++)
                    {
                        automatorOffButton[i].onClick.Invoke();
                    }
                }

                //for (int i = 0; i < requirements.Length; i++)
                //{
                //    requirements[i].isAutomated = true;
                //    //requirements[i].ExecuteAutoTrade(); // DOES NOT EXECUTE EXECUTEAUTOTRADE().
                //}

                //if (bWEF == true && bWC == true)
                //{
                //    boatWasteEnerFood.boatIsSailing = false;
                //}

                //else if (bF == true)
                //{
                //    boatFood.boatIsSailing = false;

                //}

                //else if (bEC == true)
                //{
                //    boatEnerCity.boatIsSailing = false;

                //}

            }

            else if (requirements[6].isAutopurchasable == false)
            {
                isPerSec = false;

                if (isAutomatorWithBoat == true)
                {
                    for (int i = 0; i < automatorOffButton.Length; i++)
                    {
                        automatorOffButton[i].onClick.Invoke();
                    }
                }


                //for (int i = 0; i < requirements.Length; i++)
                //{
                //    requirements[i].isAutomated = true;
                //    //requirements[i].ExecuteAutoTrade(); // DOES NOT EXECUTE EXECUTEAUTOTRADE().
                //}

                //if (bWEF == true && bWC == true)
                //{
                //    boatWasteEnerFood.boatIsSailing = false;
                //}

                //else if (bF == true)
                //{
                //    boatFood.boatIsSailing = false;

                //}

                //else if (bEC == true)
                //{
                //    boatEnerCity.boatIsSailing = false;

                //}

            }

            //else if (requirements[7].isAutopurchasable == false)
            //{
            //    isPerSec = false;

            //    //for (int i = 0; i < requirements.Length; i++)
            //    //{
            //    //    requirements[i].isAutomated = true;
            //    //    //requirements[i].ExecuteAutoTrade(); // DOES NOT EXECUTE EXECUTEAUTOTRADE().
            //    //}
            //}


            else if (requirements[0].isAutopurchasable == true && requirements[1].isAutopurchasable == true && requirements[2].isAutopurchasable == true && requirements[3].isAutopurchasable == true 
                && requirements[4].isAutopurchasable == true && requirements[5].isAutopurchasable == true && requirements[6].isAutopurchasable == true)
            {
                //int autoOn;
                //autoOn = 1;

                

                for (int i = 0; i < requirements.Length; i++)
                {
                    //requirements[i].isAutomated = true;
                    requirements[i].ExecuteAutoTrade();
                    Debug.Log("Asking to execute AutoTrade() in requirement.");

                    //if (bWEF == true && bWC == true)
                    //{
                    //    boatWasteEnerFood.boatIsSailing = true;
                    //}

                    ////else if (bWC == true)
                    ////{
                    ////    boatWasteCity.boatIsSailing = true;

                    ////}

                    //else if (bF == true)
                    //{
                    //    boatFood.boatIsSailing = true;

                    //}

                    //else if (bEC == true)
                    //{
                    //    boatEnerCity.boatIsSailing = true;

                    //}

                }
            }
            
        }
        //else
        //{
        //    int autoOff;
        //    autoOff = 0;

        //    for (int i = 0; i < requirements.Length; i++)
        //    {
        //        requirements[i].isAutomated = false;
        //    }
        //}

    }

    public void ExecuteElementsTrade()
    {
        for (int i = 0; i < requirements.Length; i++)
        {
            requirements[i].ExecuteTrade();
        }
    }

    //public void CheckRequirements()
    //{


    //    for (int i = 0; i < requirements.Length; i++)
    //    {
    //        requirements[i].VerifyIsPurchasable();
    //        if (requirements[i].isPurchasable == true)
    //        {
    //            requirementIsChecked[i] = true;
    //        }
    //        else if (requirements[i].isPurchasable == false)
    //        {
    //            requirementIsChecked[i] = false;

    //        }
    //    }

    //    if (productButton.lockObject.activeInHierarchy)
    //    {
    //        productButton.offButton.gameObject.SetActive(true);
    //    }
    //    else
    //    {
    //        // CRAZY IF STATEMENTS.
    //        //int lengthOfRequirements = requirements.Length;
    //        //if (lengthOfRequirements == 1)
    //        //{
    //        //    if (requirementIsChecked[0] == true)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(false);
    //        //    }

    //        //    else if (requirementIsChecked[0] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //}

    //        //else if (lengthOfRequirements == 2)
    //        //{
    //        //    if (requirementIsChecked[0] == true && requirementIsChecked[1] == true)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(false);
    //        //    }

    //        //    else if (requirementIsChecked[0] == true && requirementIsChecked[1] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == false && requirementIsChecked[1] == true)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == false && requirementIsChecked[1] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //}

    //        //else if (lengthOfRequirements == 3)
    //        //{

    //        //    if (requirementIsChecked[0] == true && requirementIsChecked[1] == true && requirementIsChecked[2] == true)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(false);
    //        //    }

    //        //    else if (requirementIsChecked[0] == true && requirementIsChecked[1] == true && requirementIsChecked[2] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == true && requirementIsChecked[1] == false && requirementIsChecked[2] == true)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == true && requirementIsChecked[1] == false && requirementIsChecked[2] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == false && requirementIsChecked[1] == true && requirementIsChecked[2] == true)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == false && requirementIsChecked[1] == true && requirementIsChecked[2] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }

    //        //    else if (requirementIsChecked[0] == false && requirementIsChecked[1] == false && requirementIsChecked[2] == true)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == false && requirementIsChecked[1] == false && requirementIsChecked[2] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }

    //        //}
    //        //else if (lengthOfRequirements == 4)
    //        //{
    //        //    if (requirementIsChecked[0] == true && requirementIsChecked[1] == true && requirementIsChecked[2] == true && requirementIsChecked[3] == true)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(false);
    //        //    }

    //        //    else if (requirementIsChecked[0] == true && requirementIsChecked[1] == true && requirementIsChecked[2] == true && requirementIsChecked[3] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == true && requirementIsChecked[1] == true && requirementIsChecked[2] == false && requirementIsChecked[3] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == true && requirementIsChecked[1] == false && requirementIsChecked[2] == false && requirementIsChecked[3] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == false && requirementIsChecked[1] == true && requirementIsChecked[2] == true && requirementIsChecked[3] == true)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == false && requirementIsChecked[1] == true && requirementIsChecked[2] == true && requirementIsChecked[3] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == false && requirementIsChecked[1] == true && requirementIsChecked[2] == false && requirementIsChecked[3] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == true && requirementIsChecked[1] == false && requirementIsChecked[2] == true && requirementIsChecked[3] == true)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == true && requirementIsChecked[1] == false && requirementIsChecked[2] == true && requirementIsChecked[3] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == false && requirementIsChecked[1] == false && requirementIsChecked[2] == true && requirementIsChecked[3] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == true && requirementIsChecked[1] == true && requirementIsChecked[2] == false && requirementIsChecked[3] == true)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == true && requirementIsChecked[1] == false && requirementIsChecked[2] == false && requirementIsChecked[3] == true)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == false && requirementIsChecked[1] == false && requirementIsChecked[2] == false && requirementIsChecked[3] == true)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == false && requirementIsChecked[1] == false && requirementIsChecked[2] == false && requirementIsChecked[3] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //}
    //        //else if (lengthOfRequirements == 5)
    //        //{
    //        //    if (requirementIsChecked[0] == true && requirementIsChecked[1] == true && requirementIsChecked[2] == true && requirementIsChecked[3] == true && requirementIsChecked[4] == true)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(false);
    //        //    }

    //        //    else if (requirementIsChecked[0] == true && requirementIsChecked[1] == true && requirementIsChecked[2] == true && requirementIsChecked[3] == true && requirementIsChecked[4] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == true && requirementIsChecked[1] == true && requirementIsChecked[2] == true && requirementIsChecked[3] == false && requirementIsChecked[4] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == true && requirementIsChecked[1] == true && requirementIsChecked[2] == false && requirementIsChecked[3] == false && requirementIsChecked[4] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == true && requirementIsChecked[1] == false && requirementIsChecked[2] == false && requirementIsChecked[3] == false && requirementIsChecked[4] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == false && requirementIsChecked[1] == false && requirementIsChecked[2] == false && requirementIsChecked[3] == false && requirementIsChecked[4] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == false && requirementIsChecked[1] == true && requirementIsChecked[2] == true && requirementIsChecked[3] == true && requirementIsChecked[4] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == false && requirementIsChecked[1] == true && requirementIsChecked[2] == false && requirementIsChecked[3] == true && requirementIsChecked[4] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == false && requirementIsChecked[1] == true && requirementIsChecked[2] == false && requirementIsChecked[3] == false && requirementIsChecked[4] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == false && requirementIsChecked[1] == false && requirementIsChecked[2] == true && requirementIsChecked[3] == false && requirementIsChecked[4] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == true && requirementIsChecked[1] == false && requirementIsChecked[2] == true && requirementIsChecked[3] == false && requirementIsChecked[4] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == true && requirementIsChecked[1] == false && requirementIsChecked[2] == true && requirementIsChecked[3] == true && requirementIsChecked[4] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == true && requirementIsChecked[1] == false && requirementIsChecked[2] == true && requirementIsChecked[3] == true && requirementIsChecked[4] == true)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == false && requirementIsChecked[1] == false && requirementIsChecked[2] == false && requirementIsChecked[3] == true && requirementIsChecked[4] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == true && requirementIsChecked[1] == false && requirementIsChecked[2] == false && requirementIsChecked[3] == true && requirementIsChecked[4] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == true && requirementIsChecked[1] == true && requirementIsChecked[2] == false && requirementIsChecked[3] == true && requirementIsChecked[4] == false)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == true && requirementIsChecked[1] == true && requirementIsChecked[2] == false && requirementIsChecked[3] == true && requirementIsChecked[4] == true)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == false && requirementIsChecked[1] == false && requirementIsChecked[2] == false && requirementIsChecked[3] == false && requirementIsChecked[4] == true)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == true && requirementIsChecked[1] == false && requirementIsChecked[2] == false && requirementIsChecked[3] == false && requirementIsChecked[4] == true)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == true && requirementIsChecked[1] == true && requirementIsChecked[2] == false && requirementIsChecked[3] == false && requirementIsChecked[4] == true)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }
    //        //    else if (requirementIsChecked[0] == true && requirementIsChecked[1] == true && requirementIsChecked[2] == true && requirementIsChecked[3] == false && requirementIsChecked[4] == true)
    //        //    {
    //        //        productButton.offButton.gameObject.SetActive(true);
    //        //    }

    //        //}


    //        // ORIGINAL IF STATEMENTS.
    //        //if (requirementIsChecked[0] == true && requirementIsChecked[1] == true)
    //        //{
    //        //    productButton.offButton.gameObject.SetActive(false);
    //        //}

    //        //else if (requirementIsChecked[0] == true && requirementIsChecked[1] == true && requirementIsChecked[2] == true)
    //        //{
    //        //    productButton.offButton.gameObject.SetActive(false);
    //        //}

    //        //else if (requirementIsChecked[0] == true && requirementIsChecked[1] == true && requirementIsChecked[2] == true && requirementIsChecked[3] == true)
    //        //{
    //        //    productButton.offButton.gameObject.SetActive(false);
    //        //}

    //        //else if (requirementIsChecked[0] == true && requirementIsChecked[1] == true && requirementIsChecked[2] == true && requirementIsChecked[3] == true && requirementIsChecked[4] == true)
    //        //{
    //        //    productButton.offButton.gameObject.SetActive(false);
    //        //}

    //        //else
    //        //{
    //        //    productButton.offButton.gameObject.SetActive(true);
    //        //}
    //    }

        

        //for (int i = 0; i < requirements.Length; i++)
        //{
        //    if (requirements[i].isPurchasable == true)
        //    {
        //        requirementsMet++;
        //    }

        //    requirementsMet++;

        //}

        //if (requirementsMet >= requirements.Length)
        //{
        //    productButton.offButton.gameObject.SetActive(false);
        //}
        //else
        //{
        //    productButton.offButton.gameObject.SetActive(true);

        //}

    //}

    public void UnlockDescriptor()
    {
        //prodButtUiInfoHoverer.buttonLockIsActive = false;
        //descrLockDiv.gameObject.SetActive(false);
        prodButtUiInfoHoverer.descriptorLockDiv.gameObject.SetActive(false);

    }

    public void Update()
    {


        ExecuteElementsAuto();
        //Debug.Log("Asking to execute ExecuteElementsAuto() in Update");
        //Debug.Log ("isAuto should be on here...");

        //THIS MAKES ELEMENTS AMOUNTLESS OR NOT.
        if (elemIsAmountless == true)
        {
            for (int i = 0; i < requirements.Length; i++)
            {
                requirements[i].isAmountless = true;
            }
        }

        else if (elemIsAmountless == false)
        {
            for (int i = 0; i < requirements.Length; i++)
            {
                requirements[i].isAmountless = false;
            }
        }


        // NOW, UPDATE CHECKS IF "PER SEC" SHOULD APPEAR, USING UiInfoHoverer.
        if (prodButtUiInfoHoverer.isAutomatorOrMulti == true)
        {
            for (int i = 0; i < requirements.Length; i++)
            {
                requirements[i].isAutomated = true;
            }
        }
        else if (prodButtUiInfoHoverer.isAutomatorOrMulti == false)
        {
            for (int i = 0; i < requirements.Length; i++)
            {
                requirements[i].isAutomated = false;
            }
        }


        //CheckRequirements(); // Will do the OffButton magic in TradeOffDescrElem Class.
        if (productButton.lockObject.activeInHierarchy)
        {
            prodOffButtons[5].gameObject.SetActive(true);
            prodButtUiInfoHoverer.descriptorLockDiv.gameObject.SetActive(true);
            //productButton.offButton.gameObject.SetActive(true);
        }
        else
        {
            prodOffButtons[5].gameObject.SetActive(false);
            prodButtUiInfoHoverer.descriptorLockDiv.gameObject.SetActive(false);

            //productButton.offButton.gameObject.SetActive(false);

        }

        if (buttonsUseMiniTabs == true)
        {
            if (buttonsPanel.activeInHierarchy == true)
            {
                descriptorWindowPanel.gameObject.SetActive(true);

            }
            else if (buttonsPanel.activeInHierarchy == false)
            {
                descriptorWindowPanel.gameObject.SetActive(false);

            }
        }

       



    }

}
