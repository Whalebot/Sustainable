using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewsManager : MonoBehaviour
{
    public SeenNews worldIcon;
    public Amount checkedAmount;
    public float notificationThreshold;
    public float cataclysmThreshold;
    public GameObject arrivingNews;
    public GameObject firstCataclysmWindow;
    public GameObject secondCataclysmWindow;
    //public AudioSource notification;
    public GameObject notificationSoundObj;
    public int counter;

    public void Start()
    {
        arrivingNews.gameObject.SetActive(false);
        firstCataclysmWindow.gameObject.SetActive(false);
        counter = 0;


    }

    public void CheckThresholds()
    {
        if (checkedAmount.amountFloat >= notificationThreshold && checkedAmount.amountFloat < cataclysmThreshold)
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

        else if (checkedAmount.amountFloat >= notificationThreshold && checkedAmount.amountFloat >= cataclysmThreshold)
        {
            counter++;
            firstCataclysmWindow.gameObject.SetActive(true);

        }
    }

    public void TurnOffCataclysmWindow()
    {
        secondCataclysmWindow.gameObject.SetActive(false);

    }
}
