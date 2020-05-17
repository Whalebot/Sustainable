using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaSoundDj : MonoBehaviour
{
    public float globalTime;
    public float timer;
    public float divider;
    public float divider3x;
    public float silenceWaiter; //Should not be too much above 3.
    public float lerper;
    //public float volume;
    public float volumeLimit;

    public AudioSource audioObj;
    public bool isMusic;

    public void Start()
    {
        divider3x = divider * silenceWaiter;
    }

    public void Update()
    {
        if (isMusic == false)
        {
            if (timer < divider)
            {
                timer = timer + Time.deltaTime;

            }
            else if (timer >= divider)
            {
                timer = divider;
            }

            audioObj.volume = lerper;

            if (lerper < volumeLimit)
            {
                lerper = (timer / divider);
            }
            else if (lerper >= volumeLimit)
            {
                lerper = volumeLimit;
            }
            //volume 
        }

        else if (isMusic == true)
        {
            globalTime += Time.deltaTime;

            if (globalTime < divider)
            {
                timer = timer + Time.deltaTime;
                audioObj.volume = lerper;
                if (lerper < volumeLimit)
                {
                    lerper = (timer / divider);
                }
                else if (lerper >= volumeLimit)
                {
                    lerper = volumeLimit;
                }

            }

            else if (globalTime >= divider)
            {
                timer = timer - Time.deltaTime;
                audioObj.volume = lerper;
                if ((timer/divider) <= volumeLimit)
                {
                    lerper = (timer / divider);
                }

                if (globalTime >= divider3x)
                {
                    globalTime = 0f;
                    timer = 0f;

                }
                //else if (lerper >= volumeLimit)
                //{
                //    lerper = volumeLimit;
                //}



            }

            //else if (globalTime >= (globalTime*2))
            //{
            //    globalTime = 0f;
            //}
            //timer = timer + Time.deltaTime;
            //audioObj.volume = lerper;
            //lerper = (timer / divider);


        }

    }
}
