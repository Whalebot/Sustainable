using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBgColorEqualizer : MonoBehaviour
{
    public ColorBlender01 seaColorBlender;
    public Camera mainCamera;

    public void Update()
    {
        mainCamera.backgroundColor = seaColorBlender.currentColor;
    }
}
