using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AiDescriptorHoverer : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject botPanel;

    public void Start()
    {
        botPanel.SetActive(false);

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        botPanel.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        botPanel.SetActive(false);
    }
}
