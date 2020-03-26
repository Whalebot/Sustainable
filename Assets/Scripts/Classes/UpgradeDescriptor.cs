using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeDescriptor : MonoBehaviour
{
    public bool elemIsEconomy;
    public bool elemIsFood;
    public bool elemIsEnergy;
    public bool elemIsWaste;
    public bool elemIsApproval;
    //public bool elemIsPopulation;
    public Resource checkedResource;
    public int requiredLvl;
    public List<float> requirementFloat = new List<float>();
    //public float requirementFloat;



}
