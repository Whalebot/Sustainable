using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungerCatac : MonoBehaviour
{
    //NEWS REFS
    public GameObject arrivingNews;
    public SeenNews worldIcon;
    public GameObject notificationSoundObj;

    //CATACLYSM WINDOW REFS
    public GameObject firstCataclysmWindow;
    public GameObject secondCataclysmWindow;

    // REF FOR RECOLORING NewsElement BUTTON.
    public bool isFoodHungerRelated;
    public SeenNotification hungerNewsElement;

    public void Start()
    {
        arrivingNews.gameObject.SetActive(false);

    }

    public void activateNews()
    {
        // TURN OFF FOR SEARCH
        arrivingNews.gameObject.SetActive(true);
        worldIcon.ArrivingNotification();
        notificationSoundObj.gameObject.SetActive(true);
        if (isFoodHungerRelated == true)
        {
            hungerNewsElement.RefreshedColorOfButton();

        }
    }

    public void OpenCataclysmWindow()
    {
        // CALL CATACLYSM WINDOW
        firstCataclysmWindow.gameObject.SetActive(true);

    }

    public void CloseCataclysmWindow()
    {
        secondCataclysmWindow.gameObject.SetActive(false);
    }
}
