using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffButtonSwitcher : MonoBehaviour
{
    //public GameObject activeButton;
    public GameObject inactiveOnButton;
    public GameObject inactiveOffButton;
    public bool functionIsOn;

    public void Start()
    {
        functionIsOn = false;
    }

    public void Update()
    {
        if (functionIsOn == true)
        {
            inactiveOnButton.gameObject.SetActive(false);
            inactiveOffButton.gameObject.SetActive(true);
        }

        else if (functionIsOn == false)
        {
            inactiveOnButton.gameObject.SetActive(true);
            inactiveOffButton.gameObject.SetActive(false);

        }
    }

    public void OnOffSwitcher()
    {
        functionIsOn = !functionIsOn;
    }
}
