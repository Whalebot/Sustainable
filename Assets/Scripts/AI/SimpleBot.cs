using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBot : MonoBehaviour
{
    public float counter;
    public TradeOffDescriptor poultry_simple;
    private bool purchasable = false;
    // Start is called before the first frame update
    void Start()
    {
        poultry_simple = GameObject.Find("TradeDescriptorDiv (Click) Poultry (1) (produce manual)").GetComponent<TradeOffDescriptor>();
    }

    // Update is called once per frame
    void Update()
    {
        purchasable = true;
        foreach(var item in poultry_simple.requirements)
        {
            if (item.checkedRes[1].resourceCurrent.amountFloat >= 1000) counter = Time.time;
            
            if(item.reqName == "sellEnergy") print("I am going to perform pultry sell" + item.reqName + item.checkedRes[1].resourceCurrent.amountFloat);

            item.VerifyIsPurchasable();
            if (!item.isPurchasable)
            {
                print("the time for 1000 was " + (counter - Time.time));
                purchasable = false;
                break;
            }
        }
        if(purchasable) poultry_simple.ExecuteElementsTrade();
    }
}
