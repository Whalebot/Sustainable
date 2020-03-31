using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinitabSwitcher : MonoBehaviour
{
    public GameObject[] selectedButtons;
    //public GameObject[] deselectedButtons;
    public GameObject[] backgroundPanels;

    public void Start()
    {
        selectedButtons[0].gameObject.SetActive(false);
        backgroundPanels[0].gameObject.SetActive(true);

        selectedButtons[1].gameObject.SetActive(true);
        backgroundPanels[1].gameObject.SetActive(false);

        selectedButtons[2].gameObject.SetActive(true);
        backgroundPanels[2].gameObject.SetActive(false);

        selectedButtons[3].gameObject.SetActive(true);
        backgroundPanels[3].gameObject.SetActive(false);

        selectedButtons[4].gameObject.SetActive(true);
        backgroundPanels[4].gameObject.SetActive(false);
    }

    public void ActivatePanel00()
    {
        selectedButtons[0].gameObject.SetActive(false);
        backgroundPanels[0].gameObject.SetActive(true);

        selectedButtons[1].gameObject.SetActive(true);
        backgroundPanels[1].gameObject.SetActive(false);

        selectedButtons[2].gameObject.SetActive(true);
        backgroundPanels[2].gameObject.SetActive(false);

        selectedButtons[3].gameObject.SetActive(true);
        backgroundPanels[3].gameObject.SetActive(false);

        selectedButtons[4].gameObject.SetActive(true);
        backgroundPanels[4].gameObject.SetActive(false);

    }

    public void ActivatePanel01()
    {
        selectedButtons[0].gameObject.SetActive(true);
        backgroundPanels[0].gameObject.SetActive(false);

        selectedButtons[1].gameObject.SetActive(false);
        backgroundPanels[1].gameObject.SetActive(true);

        selectedButtons[2].gameObject.SetActive(true);
        backgroundPanels[2].gameObject.SetActive(false);

        selectedButtons[3].gameObject.SetActive(true);
        backgroundPanels[3].gameObject.SetActive(false);

        selectedButtons[4].gameObject.SetActive(true);
        backgroundPanels[4].gameObject.SetActive(false);

    }

    public void ActivatePanel02()
    {
        selectedButtons[0].gameObject.SetActive(true);
        backgroundPanels[0].gameObject.SetActive(false);

        selectedButtons[1].gameObject.SetActive(true);
        backgroundPanels[1].gameObject.SetActive(false);

        selectedButtons[2].gameObject.SetActive(false);
        backgroundPanels[2].gameObject.SetActive(true);

        selectedButtons[3].gameObject.SetActive(true);
        backgroundPanels[3].gameObject.SetActive(false);

        selectedButtons[4].gameObject.SetActive(true);
        backgroundPanels[4].gameObject.SetActive(false);

    }

    public void ActivatePanel03()
    {
        selectedButtons[0].gameObject.SetActive(true);
        backgroundPanels[0].gameObject.SetActive(false);

        selectedButtons[1].gameObject.SetActive(true);
        backgroundPanels[1].gameObject.SetActive(false);

        selectedButtons[2].gameObject.SetActive(true);
        backgroundPanels[2].gameObject.SetActive(false);

        selectedButtons[3].gameObject.SetActive(false);
        backgroundPanels[3].gameObject.SetActive(true);

        selectedButtons[4].gameObject.SetActive(true);
        backgroundPanels[4].gameObject.SetActive(false);

    }

    public void ActivatePanel04()
    {
        selectedButtons[0].gameObject.SetActive(true);
        backgroundPanels[0].gameObject.SetActive(false);

        selectedButtons[1].gameObject.SetActive(true);
        backgroundPanels[1].gameObject.SetActive(false);

        selectedButtons[2].gameObject.SetActive(true);
        backgroundPanels[2].gameObject.SetActive(false);

        selectedButtons[3].gameObject.SetActive(true);
        backgroundPanels[3].gameObject.SetActive(false);

        selectedButtons[4].gameObject.SetActive(false);
        backgroundPanels[4].gameObject.SetActive(true);

    }
}
