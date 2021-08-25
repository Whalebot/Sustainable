using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBlender01 : MonoBehaviour
{
    // THE RENDERER OF THE 3D GAMEOBJECT.
    public Renderer ren;
    public Material evolvingMaterial;


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


    public void Start()
    {

        ren = gameObject.GetComponent<Renderer>();
        ren.material = evolvingMaterial;
        if (GameManager.Instance.disableGraphics) ren.enabled = false;
    }

    public void Update()
    {

        // SETS hiRes, midRes AND loRes
        // FOOD IS HIGHER.
        if ( GameManager.Instance.food >  GameManager.Instance.energy &&  GameManager.Instance.food >  GameManager.Instance.waste)
        {
            hiRes =  GameManager.Instance.food;
            colorA = foCol;

            if ( GameManager.Instance.energy >  GameManager.Instance.waste)
            {
                midRes =  GameManager.Instance.energy;
                loRes =  GameManager.Instance.waste;

                colorB = foenCol;
            }
            else if ( GameManager.Instance.energy <  GameManager.Instance.waste)
            {
                loRes =  GameManager.Instance.energy;
                midRes =  GameManager.Instance.waste;

                colorB = wafoCol;

            }
        }

        // ENERGY IS HIGHER
        else if ( GameManager.Instance.energy >  GameManager.Instance.food &&  GameManager.Instance.energy >  GameManager.Instance.waste)
        {
            hiRes =  GameManager.Instance.energy;
            //colorA = enCol;
            colorA = waCol;


            // SETS midRes AND loRes.
            if ( GameManager.Instance.food >  GameManager.Instance.waste)
            {
                midRes =  GameManager.Instance.food;
                loRes =  GameManager.Instance.waste;

                colorB = foenCol;
                //colorB = wafoCol;

            }
            else if ( GameManager.Instance.food <  GameManager.Instance.waste)
            {
                loRes =  GameManager.Instance.food;
                midRes =  GameManager.Instance.waste;

                colorB = enwaCol;
            }
        }

        // WASTE IS HIGHER
        else if ( GameManager.Instance.waste >  GameManager.Instance.food &&  GameManager.Instance.waste >  GameManager.Instance.energy)
        {
            hiRes =  GameManager.Instance.waste;
            colorA = enCol;

            if ( GameManager.Instance.energy >  GameManager.Instance.food)
            {
                midRes =  GameManager.Instance.energy;
                loRes =  GameManager.Instance.food;

                colorB = enwaCol;
            }
            else if ( GameManager.Instance.energy <  GameManager.Instance.food)
            {
                loRes =  GameManager.Instance.energy;
                midRes =  GameManager.Instance.food;

                colorB = wafoCol;

            }
        }

        bigLerper = midRes / hiRes;
        currentColor = Color.Lerp(colorA, colorB, bigLerper);
        ren.material.SetColor("_Color", currentColor);



    }
}
