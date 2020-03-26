using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour
{
    public Amount resourceTxtFloat; // Has data about current resource status.
    public Amount milestoneThreshTxtFloat;
    public float milestoneThreshExponent;
    public Amount lvlNumTxtInt;
    public RectTransform lvlLiquid;
    public float previousThreshFloat;

}
