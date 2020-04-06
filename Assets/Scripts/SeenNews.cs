using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeenNews : MonoBehaviour
{
    public GameObject notificationIcon;
    public bool newNotifications;

    // Start is called before the first frame update
    void Start()
    {
        notificationIcon.gameObject.SetActive(false);
        newNotifications = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (newNotifications == true)
        {
            notificationIcon.gameObject.SetActive(true);

        }
    }

    public void ArrivingNotification()
    {
        newNotifications = true;
    }

    public void SeeNotification()
    {
        notificationIcon.gameObject.SetActive(false);
        newNotifications = false;
    }
}
