using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmountInitial : MonoBehaviour
{
    public TextMeshProUGUI inputPlaceholder;
    public float inputAmount;
    //public float defaultAmount;

    public void Awake()
    {
        //defaultAmount = float.Parse(inputPlaceholder.text);
        inputAmount = float.Parse(inputPlaceholder.text);
    }

    public void Text_Changed(string newText)
    {
        inputAmount = float.Parse(newText);
    }
}
