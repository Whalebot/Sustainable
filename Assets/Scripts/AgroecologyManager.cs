using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgroecologyManager : MonoBehaviour
{
    public GameObject offButt01;
    public GameObject offButt02;
    public GameObject offButt03;
    public bool oneIsDeactivated;
    public bool twoIsDeactivated;
    public bool usesThree;
    public bool threeIsDeactivated;

    public void DeactivateOne()
    {
        oneIsDeactivated = true;
    }
    public void DeactivateTwo()
    {
        twoIsDeactivated = true;
    }
    public void DeactivateThree()
    {
        threeIsDeactivated = true;

    }

    public void Update()
    {
        if (usesThree == false)
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

        else if (usesThree == true)
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

            if (threeIsDeactivated == true)
            {
                offButt03.gameObject.SetActive(false);
            }
            else if (threeIsDeactivated == false)
            {
                offButt03.gameObject.SetActive(true);

            }
        }

    }
}
