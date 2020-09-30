using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CattleSmallCatac : MonoBehaviour
{
    public bool isSpecialApproval;

    // BOOL JUST FOR Footer Economy Feedbacker Light
    public bool isEmpty;

    // biogasIsActivated BECOMES TRUE WHEN THE BIOGAS UPGRADE HAS BEEN UNLOCKED. THEN, NEITHER DO Sower News NOR cataclysms RELATED TO Oil Production HAPPEN.
    public bool biogasIsActivated;

    public SeenNews worldIcon;
    public Amount checkedAmount;
    public bool checksAmount;
    public AmountSimple checkedSimpleAmount;
    public bool checksAmountSimple;
    public float notificationThreshold;
    public float cataclysmThreshold;
    public GameObject arrivingNews;
    public GameObject firstCataclysmWindow;
    public GameObject preventedCataclysmWindow;
    public GameObject secondCataclysmWindow;
    public GameObject secondPreventionWindow;

    public GameObject failedWindow;
    public GameObject failedPanel;
    public GameObject succeededWindow;
    public GameObject succeededPanel;

    //public AudioSource notification;
    public GameObject notificationSoundObj;
    public int counter;

   

    public void Start()
    {
        arrivingNews.gameObject.SetActive(false);
        firstCataclysmWindow.gameObject.SetActive(false);
        preventedCataclysmWindow.gameObject.SetActive(false);
        counter = 0;


    }

    public void CheckThresholds()
    {
        if (checksAmount == true)
        {
            if(isSpecialApproval == false)
            {
                if (checkedAmount.amountFloat >= notificationThreshold && checkedAmount.amountFloat < cataclysmThreshold)
                {
                    counter++;
                    if (counter == 1)
                    {
                        if (isEmpty == false)
                        {
                            arrivingNews.gameObject.SetActive(true);
                            worldIcon.ArrivingNotification();
                            notificationSoundObj.gameObject.SetActive(true);
                        }
                       
                    }


                }

                else if (checkedAmount.amountFloat >= notificationThreshold && checkedAmount.amountFloat >= cataclysmThreshold)
                {
                    counter++;
                    //float random = (Random.Range(-1f, 1f));
                    //Debug.Log(random);
                    //if (random < 0)
                    //{
                    //    preventedCataclysmWindow.gameObject.SetActive(true);
                    //    firstCataclysmWindow.gameObject.SetActive(false);


                    //}
                    //else if (random >= 0)
                    //{
                    firstCataclysmWindow.gameObject.SetActive(true);
                    //preventedCataclysmWindow.gameObject.SetActive(false);


                    //}

                }
            }

            else if(isSpecialApproval == true)
            {
                if (checkedAmount.amountFloat <= notificationThreshold && checkedAmount.amountFloat > cataclysmThreshold)
                {
                    counter++;
                    if (counter == 1)
                    {
                        arrivingNews.gameObject.SetActive(true);
                        worldIcon.ArrivingNotification();
                        //notification.Play();
                        notificationSoundObj.gameObject.SetActive(true);
                    }


                }

                else if (checkedAmount.amountFloat <= notificationThreshold && checkedAmount.amountFloat <= cataclysmThreshold)
                {
                    counter++;
                    //float random = (Random.Range(-1f, 1f));
                    //Debug.Log(random);
                    //if (random < 0)
                    //{
                    //    preventedCataclysmWindow.gameObject.SetActive(true);
                    //    firstCataclysmWindow.gameObject.SetActive(false);


                    //}
                    //else if (random >= 0)
                    //{
                    firstCataclysmWindow.gameObject.SetActive(true);
                    //preventedCataclysmWindow.gameObject.SetActive(false);


                    //}

                }
            }
            
        }

        else if (checksAmountSimple == true)
        {
            if (checkedSimpleAmount.simpleAmount >= notificationThreshold && checkedSimpleAmount.simpleAmount < cataclysmThreshold)
            {
                if (biogasIsActivated == false) // biogasIsActivated BECOMES TRUE WHEN THE BIOGAS UPGRADE HAS BEEN UNLOCKED. THEN, NEITHER DO Sower News NOR cataclysms RELATED TO Oil Production HAPPEN.

                {
                    counter++;
                    if (counter == 1)
                    {
                        arrivingNews.gameObject.SetActive(true);
                        worldIcon.ArrivingNotification();
                        //notification.Play();
                        notificationSoundObj.gameObject.SetActive(true);
                    }
                }
                


            }

            else if (checkedSimpleAmount.simpleAmount >= notificationThreshold && checkedSimpleAmount.simpleAmount >= cataclysmThreshold)
            {
                if (biogasIsActivated == false) // biogasIsActivated BECOMES TRUE WHEN THE BIOGAS UPGRADE HAS BEEN UNLOCKED. THEN, NEITHER DO Sower News NOR cataclysms RELATED TO Oil Production HAPPEN.

                {
                    counter++;
                    //float random = (Random.Range(-1f, 1f));
                    //Debug.Log(random);
                    //if (random < 0)
                    //{
                    //    preventedCataclysmWindow.gameObject.SetActive(true);
                    //    firstCataclysmWindow.gameObject.SetActive(false);


                    //}
                    //else if (random >= 0)
                    //{
                    firstCataclysmWindow.gameObject.SetActive(true);
                    //preventedCataclysmWindow.gameObject.SetActive(false);


                    //}
                }


            }
        }

        
    }

    public void TurnOffCataclysmWindow()
    {
        secondCataclysmWindow.gameObject.SetActive(false);
        secondPreventionWindow.gameObject.SetActive(false);

    }

    public void TurnOnOutcomeWindows()
    {
        succeededWindow.gameObject.SetActive(true);
    }

    public void TurnOffOutcomeWindows()
    {
        succeededPanel.gameObject.SetActive(false);
        failedPanel.gameObject.SetActive(false);

    }

    public void TurnBiogasBoolOn()
    {
        biogasIsActivated = true;
    }

}
