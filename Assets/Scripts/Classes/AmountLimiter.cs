using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmountLimiter : MonoBehaviour
{
    public Amount resPas;

    public float limit;

    public void Update()
    {
        if (resPas.amountFloat >= limit)
        {
            resPas.amountFloat = limit;
        }
    }
}
