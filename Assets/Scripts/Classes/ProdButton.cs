using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProdButton : MonoBehaviour
{
    public List<Product> targetProdAmount = new List<Product>(); //Only adds.
    //public List<Amount> targetProdAmount = new List<Amount>(); Type is not Amount, but Product.
    //public Amount targetProdAmount; Is list, instead.

    public List<Resource> targetResAdd = new List<Resource>();
    //public Resource targetResAdd;
    public List<ResourcePassive> targetResPassAdd = new List<ResourcePassive>();

    public List<Resource> targetResSubtract = new List<Resource>();
    //public Resource targetResSubtract;
    public List<ResourcePassive> targetResPassSubtract = new List<ResourcePassive>();

    public List<Product> influencerProd = new List<Product>();
    //public Product influencerProd;

    //public bool lockIsActive;
    //public GameObject prodDescrLockGO; This is already in UI Info Hover Class.

    public void Trade()
    {
        //Used by OnClick();
        targetProdAmount[0].amountTxt.amountFloat += influencerProd[0].quantPerClick;
        Debug.Log(targetProdAmount[0].amountTxt.amountFloat);
        targetResAdd[0].resourceCurrent.amountFloat += influencerProd[0].quantPerClick;
        targetResPassAdd[0].resourceCurrent.amountFloat += influencerProd[0].quantPerClick;
        targetResSubtract[0].resourceCurrent.amountFloat -= influencerProd[0].quantPerClick;
        targetResPassSubtract[0].resourceCurrent.amountFloat -= influencerProd[0].quantPerClick;

    }

    public void Automate()
    {

    }

    public void Update()
    {
        
    }

}
