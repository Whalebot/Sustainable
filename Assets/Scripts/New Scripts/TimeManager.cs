using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public static TimeManager Instance { get; private set; }
    public delegate void TimeEvent();
    public TimeEvent advanceGameEvent;
    public TimeEvent advanceTimeEvent;
    public float gameUpdateFrequency;
    public int day = 1;
    public int time;
    public int framesPerTime;
    int frameCounter;


    [FoldoutGroup("Time Slider")] public Slider timeSlider;
    [FoldoutGroup("Time Slider")] public TextMeshProUGUI timeText;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        day = 1;
        InitializeSlider();
        //GameManager.Instance.updateGameState += AdvanceTime;
    }

    public void InitializeSlider()
    {

        timeSlider.value = 60 - framesPerTime;
        timeText.text = "" + (int)timeSlider.value;
    }

    public void SetGameSpeed()
    {

        framesPerTime = 60 - (int)timeSlider.value;
        timeText.text = "" + (int)timeSlider.value;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameManager.paused) return;
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
            day++;
            time = 0;
            advanceGameEvent?.Invoke();
        }
        advanceTimeEvent?.Invoke();
    }
}
