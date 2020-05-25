using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceReseter : MonoBehaviour
{
    public Amount food;
    public Amount ener;
    public Amount wastem;
    public Amount money;
    public Amount pop;
    public Amount approv;
    public Amount pollut;

    public float foodFloat;
    public float enerFloat;
    public float wastemFloat;
    public float moneyFloat;
    public float popFloat;
    public float approvFloat;
    public float pollutFloat;

    public void ResetResources()
    {
        food.amountFloat = foodFloat;
        ener.amountFloat = enerFloat;
        wastem.amountFloat = wastemFloat;
        money.amountFloat = moneyFloat;
        pop.amountFloat = popFloat;
        approv.amountFloat = approvFloat;
        pollut.amountFloat = pollutFloat;

    }
}
