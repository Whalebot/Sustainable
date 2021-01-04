using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiButtonManager : MonoBehaviour
{
    public SimpleAI aiBrain;
    public GameObject aiButtonParent;
    public GameObject onButton;
    public GameObject offButton;
    public GameObject onDescrTxt;
    public GameObject offDescrTxt;

    public void Start()
    {
        aiButtonParent.SetActive(false);

    }

    public void StartAiButton()
    {
        aiButtonParent.SetActive(true);
    }

    public void ToggleAi()
    {
        aiBrain.isAIActive = !aiBrain.isAIActive;
        if (aiBrain.isAIActive == false)
        {
            offButton.SetActive(true);
            onButton.SetActive(false);

            offDescrTxt.SetActive(true);
            onDescrTxt.SetActive(false);
        }

        else if (aiBrain.isAIActive == true)
        {
            offButton.SetActive(false);
            onButton.SetActive(true);

            offDescrTxt.SetActive(false);
            onDescrTxt.SetActive(true);
        }
    }
}
