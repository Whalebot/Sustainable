using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnCamera : MonoBehaviour
{
    public GameObject virtualCam;

    public void ActivateCamera()
    {
        virtualCam.gameObject.SetActive(true);
    }
}
