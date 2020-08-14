using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAI : MonoBehaviour
{
    public float counter;
    public Amount[] importantVariables;
    public TradeOffDescriptor poultry_simple;
    private bool purchasable = false;
    // Start is called before the first frame update
    void Start() 
    {
        Camera[] cams = GameObject.FindObjectsOfType<Camera>();
        Animation[] anims = GameObject.FindObjectsOfType<Animation>();
        AudioSource[] audios = GameObject.FindObjectsOfType<AudioSource>();
        SpriteRenderer[] renderingS = GameObject.FindObjectsOfType<SpriteRenderer>();
        MeshRenderer[] renderingM = GameObject.FindObjectsOfType<MeshRenderer>();
        Canvas[] renderingC = GameObject.FindObjectsOfType<Canvas>();
        importantVariables = GameObject.FindObjectsOfType<Amount>();
        foreach(var item in cams)
        {
            item.gameObject.SetActive(false);
        }
        foreach (var item in anims)
        {
            item.enabled = false;
        }
        foreach (var item in audios)
        {
            item.enabled = false;
        }
        foreach (var item in renderingS)
        {
            item.enabled = false;
        }
        foreach (var item in renderingM)
        {
            item.enabled = false;
        }
        foreach (var item in renderingC)
        {
            item.enabled = false;
        }
        poultry_simple = GameObject.Find("TradeDescriptorDiv (Click) Poultry (1) (produce manual)").GetComponent<TradeOffDescriptor>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var imp in importantVariables)
        {
            print(imp.name);
            if (imp.name == "1 IVarAmount Population" && imp.amountFloat >= 14)
            {
                print((counter - Time.time));
                Debug.Break();
            }
        }
        purchasable = true;
        foreach (var item in poultry_simple.requirements)
        {
            if (item.checkedRes[1].resourceCurrent.amountFloat >= 1000)
            {
                counter = Time.time;
                
            }

            //if (item.reqName == "Energy") print("I am trying to perform simple chicken sell" + item.reqName + item.checkedRes[1].resourceCurrent.amountFloat);

            item.VerifyIsPurchasable();
            if (!item.isPurchasable)
            {
                //print("the time for 1000 was " + (counter - Time.time) + item + item.checkedRes[1].resourceCurrent.amountFloat);
                purchasable = false;
                break;
            }
        }
        if (purchasable)
        {
            poultry_simple.ExecuteElementsTrade();
            print("Selling!");
        }
    }
}
