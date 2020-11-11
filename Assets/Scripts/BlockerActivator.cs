using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockerActivator : MonoBehaviour
{
    public GameObject blocker;

    public void Start()
    {
        blocker.gameObject.SetActive(true);
    }

    public void TurnOffBlocker()
    {
        print(this.name);
        if(FindObjectOfType<SimpleAI>() != null)
        {
            var ai = FindObjectOfType<SimpleAI>();
            
        }
        blocker.gameObject.SetActive(false);
    }
}
