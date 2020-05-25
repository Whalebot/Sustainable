using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleObjectActivator : MonoBehaviour
{
    public GameObject obj;

    public void ActivateObj()
    {
        obj.gameObject.SetActive(true);
    }

    public void DeactivateObj()
    {
        obj.gameObject.SetActive(false);

    }
}
