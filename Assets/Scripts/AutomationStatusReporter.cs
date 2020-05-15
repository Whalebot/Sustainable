using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomationStatusReporter : MonoBehaviour
{
    public AmountSimple amountSim;
    public GameObject inactive;
    public GameObject active;

    public void Start()
    {
        inactive.gameObject.SetActive(true);
        active.gameObject.SetActive(false);
    }

    public void Update()
    {
        if (amountSim.simpleAmount <= 0)
        {
            inactive.gameObject.SetActive(true);
            active.gameObject.SetActive(false);
        }

        else if (amountSim.simpleAmount > 0)
        {
            inactive.gameObject.SetActive(false);
            active.gameObject.SetActive(true);
        }
    }
}
