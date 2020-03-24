using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UiInfoHoverer : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject specificDiv;

    //This will have to change, once I have the Descriptor Class.
    public GameObject descriptorLockDiv;
    public bool lockIsActive;

    private bool mouse_over = false;

    public void Start()
    {
        specificDiv.gameObject.SetActive(false);
    }

    void Update()
    {
        if (mouse_over)
        {
            Debug.Log("Mouse Over");
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        mouse_over = true;
        Debug.Log("Mouse enter");
        specificDiv.gameObject.SetActive(true);

        //This will have to change, once I have the Descriptor Class.
        if (lockIsActive == true)
        {
            descriptorLockDiv.gameObject.SetActive(lockIsActive);
        }
        else
        {
            descriptorLockDiv.gameObject.SetActive(lockIsActive);

        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouse_over = false;
        Debug.Log("Mouse exit");
        specificDiv.gameObject.SetActive(false);

    }

}
