using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockSpriter : MonoBehaviour
{
    public TimeManager timeManager;
    public GameObject[] clockSprite;

    private void Start()
    {
        timeManager = TimeManager.Instance;
    }

    public void Update()
    {
        if(timeManager.counter == 7)
        {
            clockSprite[0].gameObject.SetActive(true);
            clockSprite[1].gameObject.SetActive(false);
            clockSprite[2].gameObject.SetActive(false);
            clockSprite[3].gameObject.SetActive(false);
            clockSprite[4].gameObject.SetActive(false);
            clockSprite[5].gameObject.SetActive(false);
            clockSprite[6].gameObject.SetActive(false);

        }
        else if (timeManager.counter == 1)
        {
            clockSprite[0].gameObject.SetActive(false);
            clockSprite[1].gameObject.SetActive(true);
            clockSprite[2].gameObject.SetActive(false);
            clockSprite[3].gameObject.SetActive(false);
            clockSprite[4].gameObject.SetActive(false);
            clockSprite[5].gameObject.SetActive(false);
            clockSprite[6].gameObject.SetActive(false);

        }
        else if (timeManager.counter == 2)
        {
            clockSprite[0].gameObject.SetActive(false);
            clockSprite[1].gameObject.SetActive(false);
            clockSprite[2].gameObject.SetActive(true);
            clockSprite[3].gameObject.SetActive(false);
            clockSprite[4].gameObject.SetActive(false);
            clockSprite[5].gameObject.SetActive(false);
            clockSprite[6].gameObject.SetActive(false);

        }
        else if (timeManager.counter == 3)
        {
            clockSprite[0].gameObject.SetActive(false);
            clockSprite[1].gameObject.SetActive(false);
            clockSprite[2].gameObject.SetActive(false);
            clockSprite[3].gameObject.SetActive(true);
            clockSprite[4].gameObject.SetActive(false);
            clockSprite[5].gameObject.SetActive(false);
            clockSprite[6].gameObject.SetActive(false);

        }
        else if (timeManager.counter == 4)
        {
            clockSprite[0].gameObject.SetActive(false);
            clockSprite[1].gameObject.SetActive(false);
            clockSprite[2].gameObject.SetActive(false);
            clockSprite[3].gameObject.SetActive(false);
            clockSprite[4].gameObject.SetActive(true);
            clockSprite[5].gameObject.SetActive(false);
            clockSprite[6].gameObject.SetActive(false);

        }
        else if (timeManager.counter == 5)
        {
            clockSprite[0].gameObject.SetActive(false);
            clockSprite[1].gameObject.SetActive(false);
            clockSprite[2].gameObject.SetActive(false);
            clockSprite[3].gameObject.SetActive(false);
            clockSprite[4].gameObject.SetActive(false);
            clockSprite[5].gameObject.SetActive(true);
            clockSprite[6].gameObject.SetActive(false);

        }
        else if (timeManager.counter == 6)
        {
            clockSprite[0].gameObject.SetActive(false);
            clockSprite[1].gameObject.SetActive(false);
            clockSprite[2].gameObject.SetActive(false);
            clockSprite[3].gameObject.SetActive(false);
            clockSprite[4].gameObject.SetActive(false);
            clockSprite[5].gameObject.SetActive(false);
            clockSprite[6].gameObject.SetActive(true);

        }
    }
}
