using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameCapturer : MonoBehaviour
{
    public bool needsRender;
    public string playerid;
    public TextMeshProUGUI inputFieldTxt;
    public GameObject buttonOff;
    public GameObject div;
    public TMP_InputField nameInput;

    public void Start()
    {
        if (needsRender == true)
        {
            div.gameObject.SetActive(true);
        }
    }

    public void Capture()
    {
        playerid = inputFieldTxt.text;
    }

    public void Update()
    {
        

        if (nameInput.text == "")
        {
            buttonOff.gameObject.SetActive(true);
        }

        else if (nameInput.text != "")
        {
            buttonOff.gameObject.SetActive(false);

        }
    }
}
