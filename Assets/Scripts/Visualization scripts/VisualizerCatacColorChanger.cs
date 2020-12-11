using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualizerCatacColorChanger : MonoBehaviour
{
    public AmountSimple amountSimple;
    public float catacTrigger;
    public ColorBlender01 targetObjColorBlender;

    public Color fo;
    public Color wa;
    public Color en;


    void Update()
    {

        if (amountSimple.simpleAmount >= catacTrigger)
        {
            targetObjColorBlender.foCol = fo;
            targetObjColorBlender.wafoCol = fo;

            targetObjColorBlender.enCol = wa;
            targetObjColorBlender.enwaCol = wa;

            targetObjColorBlender.waCol = en;
            targetObjColorBlender.foenCol = en;
        }
        

    }
}
