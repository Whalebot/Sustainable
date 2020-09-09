using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
{
    public Amount resourceAmount;
    public float giftAmount;

    public void GiveGift()
    {
        resourceAmount.amountFloat += giftAmount;
    }
}
