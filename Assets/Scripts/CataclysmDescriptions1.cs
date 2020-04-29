using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;


public class CataclysmDescriptions1 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    //public GameObject description;
    public TextMeshProUGUI description;
    private bool mouse_over = false;

    public void Start()
    {
        //description.gameObject.SetActive(false);
        description.enabled = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        mouse_over = true;
        //description.gameObject.SetActive(true);
        description.enabled = true;



    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouse_over = false;
        //description.gameObject.SetActive(false);
        description.enabled = false;



    }

}
