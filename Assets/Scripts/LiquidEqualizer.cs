using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiquidEqualizer : MonoBehaviour
{
    public Image follower;
    public Image following;

    // Update is called once per frame
    void Update()
    {
        follower.fillAmount = following.fillAmount;
    }
}
