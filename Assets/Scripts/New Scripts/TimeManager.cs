using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class TimeManager : MonoBehaviour
{
    public static TimeManager Instance { get; private set; }
    public delegate void TimeEvent();
    public TimeEvent advanceGameEvent;
    public TimeEvent advanceTimeEvent;
    public float gameUpdateFrequency;
    public int time;
    public int framesPerTime;
    int frameCounter;
    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Waits framesPerTime amount of frames before advancing the the game time
        frameCounter++;
        if (frameCounter >= framesPerTime)
        {
            AdvanceTime();
        }


    }

    public void AdvanceTime()
    {
        frameCounter = 0; 
        time++;
        //When game time has completed a cycle, the game advances its game state
        if (time >= 7)
        {
            time = 0;
            advanceGameEvent?.Invoke();
        }
        advanceTimeEvent?.Invoke();
    }
}
