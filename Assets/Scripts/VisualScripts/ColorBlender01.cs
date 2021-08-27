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
        // Food IS HIGHER.
        if ( GameManager.Instance.Food >  GameManager.Instance.Energy &&  GameManager.Instance.Food >  GameManager.Instance.Waste)
        {
            hiRes =  GameManager.Instance.Food;
            colorA = foCol;

            if ( GameManager.Instance.Energy >  GameManager.Instance.Waste)
            {
                midRes =  GameManager.Instance.Energy;
                loRes =  GameManager.Instance.Waste;

                colorB = foenCol;
            }
            else if ( GameManager.Instance.Energy <  GameManager.Instance.Waste)
            {
                loRes =  GameManager.Instance.Energy;
                midRes =  GameManager.Instance.Waste;

                colorB = wafoCol;

            }
        }

        // Energy IS HIGHER
        else if ( GameManager.Instance.Energy >  GameManager.Instance.Food &&  GameManager.Instance.Energy >  GameManager.Instance.Waste)
        {
            hiRes =  GameManager.Instance.Energy;
            //colorA = enCol;
            colorA = waCol;


            // SETS midRes AND loRes.
            if ( GameManager.Instance.Food >  GameManager.Instance.Waste)
            {
                midRes =  GameManager.Instance.Food;
                loRes =  GameManager.Instance.Waste;

                colorB = foenCol;
                //colorB = wafoCol;

            }
            else if ( GameManager.Instance.Food <  GameManager.Instance.Waste)
            {
                loRes =  GameManager.Instance.Food;
                midRes =  GameManager.Instance.Waste;

                colorB = enwaCol;
            }
        }

        // Waste IS HIGHER
        else if ( GameManager.Instance.Waste >  GameManager.Instance.Food &&  GameManager.Instance.Waste >  GameManager.Instance.Energy)
        {
            hiRes =  GameManager.Instance.Waste;
            colorA = enCol;

            if ( GameManager.Instance.Energy >  GameManager.Instance.Food)
            {
                midRes =  GameManager.Instance.Energy;
                loRes =  GameManager.Instance.Food;

                colorB = enwaCol;
            }
            else if ( GameManager.Instance.Energy <  GameManager.Instance.Food)
            {
                loRes =  GameManager.Instance.Energy;
                midRes =  GameManager.Instance.Food;

                colorB = wafoCol;

            }
        }

        bigLerper = midRes / hiRes;
        currentColor = Color.Lerp(colorA, colorB, bigLerper);
        ren.material.SetColor("_BaseColor", currentColor);



    }
}
