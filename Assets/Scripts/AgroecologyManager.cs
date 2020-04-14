using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgroecologyManager : MonoBehaviour
{
    public GameObject offButt01;
    public GameObject offButt02;
    public bool oneIsDeactivated;
    public bool twoIsDeactivated;

    public void DeactivateOne()
    {
        oneIsDeactivated = true;
    }
    public void DeactivateTwo()
    {
        twoIsDeactivated = true;
    }

    public void Update()
    {
        if (oneIsDeactivated == true)
        {
            offButt01.gameObject.SetActive(false);
        }
        else if (oneIsDeactivated == false)
        {
            offButt01.gameObject.SetActive(true);

        }

        if (twoIsDeactivated == true)
        {
            offButt02.gameObject.SetActive(false);
        }
        else if (twoIsDeactivated == false)
        {
            offButt02.gameObject.SetActive(true);

        }
    }
}
