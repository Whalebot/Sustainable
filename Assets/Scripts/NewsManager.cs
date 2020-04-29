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
    public GameObject cataclysmWindow;

    public void Start()
    {
        arrivingNews.gameObject.SetActive(false);
        cataclysmWindow.gameObject.SetActive(false);


    }

    public void CheckThresholds()
    {
        if (checkedAmount.amountFloat >= notificationThreshold)
        {
            arrivingNews.gameObject.SetActive(true);
            worldIcon.ArrivingNotification();
        }

        else if (checkedAmount.amountFloat >= notificationThreshold && checkedAmount.amountFloat >= cataclysmThreshold)
        {
            cataclysmWindow.gameObject.SetActive(true);

        }
    }

    public void TurnOffCataclysmWindow()
    {
        cataclysmWindow.gameObject.SetActive(false);

    }
}
