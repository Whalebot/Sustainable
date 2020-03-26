using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Amount : MonoBehaviour
{
    public TextMeshProUGUI amountTxt;
    public float amountFloat;
    public int onlyLvlInt; //Only use this reference if GameObj is a milestone.
    public List<GameObject> amountIcon = new List<GameObject>();


}
