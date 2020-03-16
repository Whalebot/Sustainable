using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnObject : MonoBehaviour
{
    //THIS SCRIPT MUST BE A COMPONENT OF CLICKABLE OBJECT

    //Text references
    public TextMesh textMesh;

    //Ray references
    Vector3 clickPos;
    bool clicked;    

    //Halo references
    public GameObject haloObj;
    public Transform haloPos;

    public Transform hiddenPos;
    public Transform[] interactablePos;
    public GameObject div;

    public void Start()
    {
        div.transform.position = hiddenPos.position;
        haloObj.gameObject.SetActive(false);
    }

    //public void Update()
    //{
    //clicked = Input.touchCount > 0;
    //if (clicked)
    //{
    //    clickPos = Input.GetTouch(0).position;

    //}
    //else if (clicked = Input.GetMouseButtonDown(0))
    //{
    //    clickPos = Input.mousePosition;

    //}

    //RaycastHit hit;
    //Ray ray = Camera.main.ScreenPointToRay(clickPos);
    //if (Physics.Raycast(ray, out hit) && clicked)
    //{
    //    Debug.Log("Clicked on gameobject: " + hit.collider.name);
    //    textMesh.text = ("Yo!");
    //    div.transform.position = interactablePos[0].position;
    //    haloObj.gameObject.SetActive(true);
    //    haloObj.transform.localPosition = haloObj.transform.localPosition + new Vector3(0.318f, -0.848f, 0.318f);

    //}

    //}

    public void OnMouseOver()
    {
        textMesh.text = ("Yo!");
        div.transform.position = interactablePos[0].position;
        haloObj.gameObject.SetActive(true);
        haloObj.transform.localPosition = /*haloObj.transform.localPosition +*/ new Vector3(0.318f, -0.848f, 0.318f);
    }

    public void OnMouseExit()
    {
        textMesh.text = ("Exited");
        div.transform.position = hiddenPos.position;
        haloObj.transform.localPosition = /*haloObj.transform.localPosition +*/ new Vector3(0f, 0f, 0f);
        haloObj.gameObject.SetActive(false);
    }



}
