using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAI : MonoBehaviour
{
    public float counter;
    public bool derender = true;
    public Amount[] importantVariables;
    public DisruptionManager[] cataclisms;
    public GameObject[] ChickenManual;
    public GameObject[] ChickenPlus01;
    public GameObject[] ChickenPlus02;

    public GameObject[] VeggiesManual;
    public GameObject[] VeggiesPlus01;
    public GameObject[] VeggiesPlus02;

    public GameObject[] InsectsManual;
    public GameObject[] InsectsPlus01;
    public GameObject[] InsectsPlus02;

    public GameObject[] AlgaeManual;
    public GameObject[] AlgaePlus01;
    public GameObject[] AlgaePlus02;

    public GameObject[] EnergyManual;
    public GameObject[] EnergyPlus01;
    public GameObject[] EnergyPlus02;

    public GameObject[] WasteManual;
    public GameObject[] WastePlus01;
    public GameObject[] WastePlus02;
    public GameObject[] WastePlus03;
    public GameObject[] WastePlus04;
    public GameObject[] WastePlus05;
    public GameObject[] WastePlus06;
    public GameObject[] WastePlus07;

    public GameObject[] ChickenUpgrade01;
    public GameObject[] ChickenUpgrade02;
    public GameObject[] ChickenUpgrade03;

    public GameObject[] VeggiesUpgrade01;
    public GameObject[] VeggiesUpgrade02;
    public GameObject[] VeggiesUpgrade03;

    public GameObject[] InsectsUpgrade01;
    public GameObject[] InsectsUpgrade02;
    public GameObject[] InsectsUpgrade03;

    public GameObject[] AlgaeUpgrade01;
    public GameObject[] AlgaeUpgrade02;
    public GameObject[] AlgaeUpgrade03;

    public GameObject[] EnergyUpgrade01;
    public GameObject[] EnergyUpgrade02;
    public GameObject[] EnergyUpgrade03;

    public GameObject[] WasteUpgrade01;
    public GameObject[] WasteUpgrade02;
    public GameObject[] WasteUpgrade03;

    public TradeOffDescriptor poultry_simple;
    private bool purchasable = false;
    // Start is called before the first frame update
    void Start() 
    {
        if (derender)
        {
            Camera[] cams = GameObject.FindObjectsOfType<Camera>();
            Animation[] anims = GameObject.FindObjectsOfType<Animation>();
            AudioSource[] audios = GameObject.FindObjectsOfType<AudioSource>();
            SpriteRenderer[] renderingS = GameObject.FindObjectsOfType<SpriteRenderer>();
            MeshRenderer[] renderingM = GameObject.FindObjectsOfType<MeshRenderer>();
            Canvas[] renderingC = GameObject.FindObjectsOfType<Canvas>();
           
        
            foreach (var item in cams)
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
        }
        importantVariables = GameObject.FindObjectsOfType<Amount>();
        //poultry_simple = GameObject.Find("TradeDescriptorDiv (Click) Poultry (1) (produce manual)").GetComponent<TradeOffDescriptor>();

        TradeOffDescriptor[] trades = GameObject.FindObjectsOfType<TradeOffDescriptor>();
        UpgradeDescriptor[] upgrades = GameObject.FindObjectsOfType<UpgradeDescriptor>();
        
        print(trades.Length+ " , , " +upgrades.Length + " " + cataclisms.Length);
        foreach (var item in cataclisms)
        {
            print(item.name + "and is" +item.isActiveAndEnabled);
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var imp in importantVariables)
        {
            //print(imp.name + imp.amountFloat);
            if (imp.name == "1 IVarAmount Population" && imp.amountFloat >= 14)
            {
                
            }
        }
        purchasable = true;
        foreach (var item in poultry_simple.requirements)
        {
            if (item.checkedRes[1].resourceCurrent.amountFloat >= 100)
            {
                print((counter - Time.time));
                Debug.Break();
                counter = Time.time;
                
            }
            foreach (DisruptionManager cataclism in cataclisms)
            {
                if (cataclism.isActiveAndEnabled)
                    cataclism.ApplyDisruption();
            }
            //if (item.reqName == "Energy") print("I am trying to perform simple chicken sell" + item.reqName + item.checkedRes[1].resourceCurrent.amountFloat);
            //foreach (var j in item.checkedRes)
            //{
            //    print(j.name + j.resourceCurrent.amountFloat);
            //}
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
            //poultry_simple.ExecuteElementsTrade();
            //print("Selling!");
        }
    }
}
