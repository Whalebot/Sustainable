using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Production Method", menuName = "Production")]
public class ProductionSO : ScriptableObject
{
    public int energy;
    public int food;
    public int waste;

    public int foodShortage;
    public int approval;
    public int population;
    public int money;
    public int pollution;
    public int bees;
}
