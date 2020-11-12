using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class BlockerActivator : MonoBehaviour
{
    public GameObject blocker;

    public void Start()
    {
        blocker.gameObject.SetActive(true);
    }

    public void TurnOffBlocker()
    {
        if(FindObjectOfType<SimpleAI>() != null)
        {
            var ai = FindObjectOfType<SimpleAI>();
            if(ai.bottype != BotTypes.Nada)
            {
                print("IAMHERE");
                ai.isAIActive = true;
            }
        }
        blocker.gameObject.SetActive(false);
    }
}
