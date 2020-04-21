using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkOceanBlender : MonoBehaviour
{
    public ColorBlender01 sea;
    public ResourcePassive pollutionResPas;
    public float threshold;
    public float lerper;

    public Color lightFo;
    public Color darkFo;
    public Color lightEn;
    public Color darkEn;
    public Color lightWa;
    public Color darkWa;

    public Color lightWaFo;
    public Color darkWaFo;
    public Color lightFoEn;
    public Color darkFoEn;
    public Color lightEnWa;
    public Color darkEnWa;
    public Color lightFoEnWa;
    public Color darkFoEnWa;


    public void Update()
    {
        lerper = pollutionResPas.resourceCurrent.amountFloat / threshold;
        //vignetteImg.color = Color.Lerp(whiteTrans, whiteOpaq, lerper);
        //sea.ren.material.SetColor("_Color", currentColor);
        sea.foCol = Color.Lerp(lightFo, darkFo, lerper);
        sea.enCol = Color.Lerp(lightEn, darkEn, lerper);
        sea.waCol = Color.Lerp(lightWa, darkWa, lerper);

        sea.foenCol = Color.Lerp(lightFoEn, darkFoEn, lerper);
        sea.wafoCol = Color.Lerp(lightWaFo, darkWaFo, lerper);
        sea.enwaCol = Color.Lerp(lightEnWa, darkEnWa, lerper);
        sea.foenwaCol = Color.Lerp(lightFoEnWa, darkFoEnWa, lerper);




    }

}
