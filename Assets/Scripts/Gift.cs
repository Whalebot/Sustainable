using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
{
    public Amount resourceAmount;
    public float giftAmount;
    public float takeAmount;

    public void GiveGift()
    {
        resourceAmount.amountFloat += giftAmount;
    }

    public void TakeFood()
    {
        resourceAmount.amountFloat -= takeAmount;

    }
}
