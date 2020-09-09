using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulationZeroManager : MonoBehaviour
{

    public Amount populationAmount;
    public float lowerLimit;

    void Update()
    {
        if (populationAmount.amountFloat <= 9)
        {
            populationAmount.amountFloat = 10f;
        }
    }
}
