using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpButton : MonoBehaviour
{
    public bool isOnlyOnePurchase;
    //public List<ProdButton> targetProdButton = new List<ProdButton>(); 
    public ProdButton targetProdButton;
    public GameObject prodButtLock;
    //public List<Product> targetProduct = new List<Product>(); Upgrades don't upgrade Products, they upgrade how ProdButtons perform and how they affect a Product.
    //public Product targetProduct; Is list instead.
    //public Product targetProdLockGO; This is already contained in Product targetProduct.
    public bool targetIsAlsoUpCost; //Check if upgrade can be clicked several times to improve a ProdButton Productivity.
    public Upgrade relatedUpgrade; //The upgrade may become more expensive.
    public TextMeshProUGUI upName;
    public UiInfoHoverer upUihProdButtToUnlock;
    public UpgradeDescriptor upDescriptor;
    public GameObject checkIcon;

    public GameObject offButton;


    public void UnlockProduct()
    {
        prodButtLock.gameObject.SetActive(false);
        upDescriptor.upIsPurchased = true;        
        checkIcon.gameObject.SetActive(true);

        //targetProdButton.lockObject.gameObject.SetActive(false);

        //if(isOnlyOnePurchase == true)
        //{
        //    upUihProdButtToUnlock.buttonLockIsActive = false;

        //}
        //else if (isOnlyOnePurchase == false)
        //{
        //    upUihProdButtToUnlock.buttonLockIsActive = false;

        //}
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

    public void TransformToAutoProdButt()
    {
        targetProdButton.isTriggeringAuto = true;
        targetProdButton.tradeDescriptor.isAuto = true;

        for (int i = 0; i < targetProdButton.tradeDescriptor.requirements.Length; i++)
        {
            targetProdButton.tradeDescriptor.requirements[i].isAutomated = true;
        }

    }

}
