using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeActivator : MonoBehaviour
{
    public GameObject wasteSmoke1;



    public void ActivateSmk01Waste()
    {
        wasteSmoke1.gameObject.SetActive(true);
    }
}
