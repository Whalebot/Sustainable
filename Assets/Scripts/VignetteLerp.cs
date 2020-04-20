using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VignetteLerp : MonoBehaviour
{
    public ResourcePassive pollutionResPas;
    public float threshold;
    public float lerper;
    public Image vignetteImg;
    public Color whiteTrans;
    public Color whiteOpaq;

    public void Start()
    {
        whiteTrans = new Color32(255, 255, 255, 0);
        whiteOpaq = new Color32(255, 255, 255, 255);

    }

    public void Update()
    {
        lerper = pollutionResPas.resourceCurrent.amountFloat / threshold;
        vignetteImg.color = Color.Lerp(whiteTrans, whiteOpaq, lerper);

        
    }
}
