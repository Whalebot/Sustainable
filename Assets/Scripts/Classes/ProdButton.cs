using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProdButton : MonoBehaviour
{
    public List<Amount> targetProdAmount = new List<Amount>();
    //public Amount targetProdAmount; Is list, instead.
    public List<Resource> targetResAdd = new List<Resource>();
    //public Resource targetResAdd;
    public List<Resource> targetResSubtract = new List<Resource>();
    //public Resource targetResSubtract;
    public List<Product> influencerProd = new List<Product>();
    //public Product influencerProd;
    public bool lockIsActive;
    public GameObject prodDescrLockGO;



    public void Automate()
    {

    }


}
