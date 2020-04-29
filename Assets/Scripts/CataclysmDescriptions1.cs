using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class CataclysmDescriptions1 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject description;
    private bool mouse_over = false;

    public void Start()
    {
        description.gameObject.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        mouse_over = true;
        description.gameObject.SetActive(true);


    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouse_over = false;
        description.gameObject.SetActive(false);


    }

}
