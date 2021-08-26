using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockSpriter : MonoBehaviour
{
    TimeManager timeManager;
    public GameObject[] clockSprite;

    private void Start()
    {
        timeManager = TimeManager.Instance;
        timeManager.advanceTimeEvent += UpdateClock;
    }

    void UpdateClock()
    {
        for (int i = 0; i < clockSprite.Length; i++)
        {
            clockSprite[i].SetActive(timeManager.time == i);

        }
    }
}
