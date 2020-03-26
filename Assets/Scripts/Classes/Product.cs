using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Product : MonoBehaviour
{
    //public float quantityPerClick;
    //public float costPerClick;

    //quantityPerClick *= 1.5; //Exponential
    //quantityPerClick*= (1+Random.value); //Uneven

    //public GameObject prodLockGO; This goes in ProdButton instead.
    public float quantPerClick;
    public float costPerClick;
    public bool autoIsActive;
    public float quantPerSec;
    public float costPerSec;
    public Amount amountTxt;
    //public TextMeshProUGUI prodAmountTxt; Amount amountTxt already has TMProUGUI and float.



}
