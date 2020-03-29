using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public float prodQuantityMultiplier;
    public float prodCostDivider;
    public float upCostMultiplier;
    public float upCostPerClick;
    public int requiredResLvl;
    public Resource resLvl;
    public List<Product> checkedProdAmount = new List<Product>();
    public UpgradeDescriptor requiredResAmount; //Check if the amount in the checkedProdAmount matches the requiredAmount in UpDescriptor.
    public List<float> prodCost = new List<float>();
    public string upgradeName;

    //This references are used when checking if upgrade is available.


    //public void SwitchUpAvailab()
    //{

    //}

}
