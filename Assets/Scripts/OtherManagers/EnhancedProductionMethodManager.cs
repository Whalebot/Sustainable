using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnhancedProductionMethodManager : MonoBehaviour
{
    public bool needsRender;
    public GameObject popUp;
    public float timer;
    //public bool stopped;

    public void Start()
    {
        if (needsRender == true)
        {
            popUp.gameObject.SetActive(false);
        }
    }

    public void PopUpMessage()
    {
        if (needsRender == true)
        {
            popUp.gameObject.SetActive(false);
            popUp.gameObject.SetActive(true);

        }

        
    }

    

}
