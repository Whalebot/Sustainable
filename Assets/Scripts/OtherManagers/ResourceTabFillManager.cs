using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceTabFillManager : MonoBehaviour
{
    // AI BOTS BOOL
    public bool needsRender;

    // REFS: RESOURCE TAB FILLS
    public Image foodFill;
    public Image energyFill;
    public Image processedWasteFill;

    // REFS: Amounts OF RESOURCES
    public Amount foodAmount;
    public Amount energyAmount;
    public Amount processedWasteAmount;

    // VARS: FLOATS
    public float totalFoEnWaResources;
    public float foodPercent;
    public float energyPercent;
    public float processedWastePercent;

    public void FillLiquid()
    {
        
        // TOTAL RESOURCES OF FOOD, ENERGY, AND PROCESSED WASTE.
        totalFoEnWaResources = foodAmount.amountFloat + energyAmount.amountFloat + processedWasteAmount.amountFloat;

        // FOOD FILL PERCENTAGE
        foodPercent = (foodAmount.amountFloat / totalFoEnWaResources);
        foodFill.fillAmount = foodPercent;

        // ENERGY FILL PERCENTAGE
        energyPercent = (energyAmount.amountFloat / totalFoEnWaResources);
        energyFill.fillAmount = energyPercent;

        // PROCESSED WASTE FILL PERCENTAGE
        processedWastePercent = (processedWasteAmount.amountFloat / totalFoEnWaResources);
        processedWasteFill.fillAmount = processedWastePercent;

    }

    // Update is called once per frame
    void Update()
    {
        if (needsRender == true)
        {
            FillLiquid();

        }
    }
}
