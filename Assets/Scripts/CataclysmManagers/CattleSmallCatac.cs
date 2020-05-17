using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CattleSmallCatac : MonoBehaviour
{
    public float catacCounter;
    public float warningThreshold;
    public float disruptionThreshold;

    public bool hasWarned;
    public bool hasDisrupted;

    public void AddCatacPoints()
    {
        catacCounter++;

    }

    public void WarningVerifier()
    {

    }

}
