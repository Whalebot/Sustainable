using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpButton : MonoBehaviour
{
    public List<ProdButton> targetProdButton = new List<ProdButton>();
    //public List<Product> targetProduct = new List<Product>(); Upgrades don't upgrade Products, they upgrade ProdButtons.
    //public Product targetProduct; Is list instead.
    //public Product targetProdLockGO; This is already contained in Product targetProduct.
    public Upgrade targetUpgrade; //The upgrade may become more expensive.



    public void UnlockProduct()
    {

    }

    public void MultiplyUpCost()
    {

    }

    public void MultiplyProdQuantPerClick()
    {

    }

    public void MultiplyProdQuantPerSec()
    {

    }

    public void DivideProdCostPerClick()
    {

    }

    public void DivideProdCostPerSec()
    {

    }

    public void EnableAutoProd()
    {

    }

}
