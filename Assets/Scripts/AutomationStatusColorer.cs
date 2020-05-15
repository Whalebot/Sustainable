using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutomationStatusColorer : MonoBehaviour
{
    // COLORS
    public Color inactCol;
    public Color actCol;
    public Image autoPseudoButton;
    public GameObject actObj;
    public GameObject inactObj;

    public void Start()
    {
        autoPseudoButton.color = inactCol;
    }

    public void Update()
    {
        if (inactObj.activeInHierarchy == true)
        {
            autoPseudoButton.color = inactCol;

        }
        else if (actObj.activeInHierarchy == true)
        {
            autoPseudoButton.color = actCol;

        }
    }
}
