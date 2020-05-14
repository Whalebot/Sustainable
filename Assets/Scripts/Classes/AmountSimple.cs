using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmountSimple : MonoBehaviour
{
    public float simpleAmount;
    public TextMeshProUGUI tmpText;

    public void Start()
    {
        tmpText = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void Update()
    {
        tmpText.text = simpleAmount.ToString("0");
    }

    public void AddOne()
    {
        simpleAmount++;
    }
}
