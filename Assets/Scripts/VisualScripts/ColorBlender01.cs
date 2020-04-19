using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBlender01 : MonoBehaviour
{
    // THE RENDERER OF THE 3D GAMEOBJECT.
    public Renderer ren;
    public Material evolvingMaterial;

    // WILL BE USING resAmounts.
    public Resource foodResource;
    public Resource energyResource;
    public Resource wasteResource;
    //// FLOATS TO TEST resAmount CHANGES.
    //public float foodValue;
    //public float enerValue;
    //public float wasteValue;

    // FLOATS FILLED WITH resAmounts.
    public float hiRes;
    public float midRes;
    public float loRes;

    // LERPED COLORS REFS. 
    // "A" WILL CHANGE BETWEEN fo, en, wa. 
    // "B" WILL CHANGE BETWEEN foen, enwa, wafo.
    public float bigLerper; // THIS WILL BE THE QUOTIENT OF A DIVISION BETWEEN resAmounts. IT WILL TRANSITION BETWEEN colorA AND colorB.
    public Color currentColor;
    public float timeLerper; // THIS WILL SMOOTHLY SWITCH colorA WITH ANOTHER colorA. THE SAME FOR colorB's.
    public Color colorA;
    public Color colorB;


    // PURE COLORS
    public Color foCol;
    public Color enCol;
    public Color waCol;

    // MIXED COLORS
    public Color foenCol;
    public Color enwaCol;
    public Color wafoCol;
    public Color foenwaCol;



    //public void Awake()
    //{
    //    var objRenderer = gameObject.GetComponent<Renderer>();
    //}

    public void Start()
    {
        //// FOR TEST OF resAmount CHANGES
        //foodValue = foodResource.resourceCurrent.amountFloat;
        //enerValue = energyResource.resourceCurrent.amountFloat;
        //wasteValue = wasteResource.resourceCurrent.amountFloat;

        ren = gameObject.GetComponent<Renderer>();
        ren.material = evolvingMaterial;

        // SET PURE COLORS
        foCol = new Color32(229, 231, 107, 255);
        waCol = new Color32(166, 221, 217, 255);
        enCol = new Color32(232, 138, 219, 255);

        // SET MIXED COLORS
        wafoCol = new Color32(255, 140, 139, 255);
        enwaCol = new Color32(154, 148, 242, 255);
        foenCol = new Color32(158, 230, 115, 255);
        //foenwaCol = new Color32(250, 250, 250, 255);
        foenwaCol = new Color32(185, 185, 185, 255);


    }

    public void Update()
    {
        //// FOR TEST OF resAmount CHANGES
        //foodResource.resourceCurrent.amountFloat = foodValue;
        //energyResource.resourceCurrent.amountFloat = enerValue;
        //wasteResource.resourceCurrent.amountFloat = wasteValue;

        // SETS hiRes, midRes AND loRes
        // FOOD IS HIGHER.
        if (foodResource.resourceCurrent.amountFloat > energyResource.resourceCurrent.amountFloat && foodResource.resourceCurrent.amountFloat > wasteResource.resourceCurrent.amountFloat)
        {
            hiRes = foodResource.resourceCurrent.amountFloat;
            colorA = foCol;

            // SETS midRes AND loRes.
            if (energyResource.resourceCurrent.amountFloat > wasteResource.resourceCurrent.amountFloat)
            {
                midRes = energyResource.resourceCurrent.amountFloat;
                loRes = wasteResource.resourceCurrent.amountFloat;

                colorB = foenCol;
                //if (colorB == foenCol)
                //{
                //    colorB = foenCol;
                //}
                //else if (colorB == wafoCol)
                //{
                //    colorB = Color.Lerp(wafoCol, foenCol, timeLerper * Time.deltaTime);
                //}
                //colorB = Color.Lerp(wafoCol, foenCol, timeLerper * Time.deltaTime);
            }
            else if (energyResource.resourceCurrent.amountFloat < wasteResource.resourceCurrent.amountFloat)
            {
                loRes = energyResource.resourceCurrent.amountFloat;
                midRes = wasteResource.resourceCurrent.amountFloat;

                colorB = wafoCol;
                //if (colorB == wafoCol)
                //{
                //    colorB = wafoCol;
                //}
                //else if (colorB == foenCol)
                //{
                //    colorB = Color.Lerp(foenCol, wafoCol, timeLerper * Time.deltaTime);
                //}
                //colorB = Color.Lerp(foenCol, wafoCol, timeLerper * Time.deltaTime);
            }
        }

        // ENERGY IS HIGHER
        else if (energyResource.resourceCurrent.amountFloat > foodResource.resourceCurrent.amountFloat && energyResource.resourceCurrent.amountFloat > wasteResource.resourceCurrent.amountFloat)
        {
            hiRes = energyResource.resourceCurrent.amountFloat;
            colorA = enCol;

            // SETS midRes AND loRes.
            if (foodResource.resourceCurrent.amountFloat > wasteResource.resourceCurrent.amountFloat)
            {
                midRes = foodResource.resourceCurrent.amountFloat;
                loRes = wasteResource.resourceCurrent.amountFloat;

                colorB = foenCol;
            }
            else if (foodResource.resourceCurrent.amountFloat < wasteResource.resourceCurrent.amountFloat)
            {
                loRes = foodResource.resourceCurrent.amountFloat;
                midRes = wasteResource.resourceCurrent.amountFloat;

                colorB = enwaCol;
            }
        }

        // WASTE IS HIGHER
        else if (wasteResource.resourceCurrent.amountFloat > foodResource.resourceCurrent.amountFloat && wasteResource.resourceCurrent.amountFloat > energyResource.resourceCurrent.amountFloat)
        {
            hiRes = wasteResource.resourceCurrent.amountFloat;
            colorA = waCol;

            // SETS midRes AND loRes.
            if (energyResource.resourceCurrent.amountFloat > foodResource.resourceCurrent.amountFloat)
            {
                midRes = energyResource.resourceCurrent.amountFloat;
                loRes = foodResource.resourceCurrent.amountFloat;

                colorB = enwaCol;
            }
            else if (energyResource.resourceCurrent.amountFloat < foodResource.resourceCurrent.amountFloat)
            {
                loRes = energyResource.resourceCurrent.amountFloat;
                midRes = foodResource.resourceCurrent.amountFloat;

                colorB = wafoCol;
            }
        }

        // ALL RESOURCES ARE EQUAL
        else if (foodResource.resourceCurrent.amountFloat == energyResource.resourceCurrent.amountFloat && foodResource.resourceCurrent.amountFloat == wasteResource.resourceCurrent.amountFloat)
        {
            colorA = foenwaCol;
            colorB = foenwaCol;
        }

        // THIS SHOULD LERP colorA WITH sustituteA
        //if (hiRes == foodResource.resourceCurrent.amountFloat)

        // THIS SHOULD LERP BETWEEN PURE AND MIXED COLORS.
        //lerpedFoodCol = Color.Lerp(foodCol, enerCol, foodValue);
        bigLerper = midRes / hiRes;
        currentColor = Color.Lerp(colorA, colorB, bigLerper);
        ren.material.SetColor("_Color", currentColor);



    }
}
