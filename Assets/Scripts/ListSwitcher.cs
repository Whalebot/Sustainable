using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListSwitcher : MonoBehaviour
{
    public GameObject list;
    public bool switcher;

    public void Start()
    {
        switcher = false;
        list.gameObject.SetActive(false);
    }

    public void switchList()
    {
        switcher = !switcher;
        list.gameObject.SetActive(switcher);

    }
}
