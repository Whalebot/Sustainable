﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

    List<GameObject[]> upgradeList = new List<GameObject[]>();
    List<GameObject[]> buttonList = new List<GameObject[]>();

    List<GameObject[]> upgradeActions = new List<GameObject[]>();
    List<GameObject[]> buttonActions = new List<GameObject[]>();
    List<GameObject[]> AllActions = new List<GameObject[]>();

    List<GameObject[]> chickenUpdate01 = new List<GameObject[]>();
    private bool chickenUPHappened01 = false;
    List<GameObject[]> chickenUpdate02 = new List<GameObject[]>();
    private bool chickenUPHappened02 = false;

    List<GameObject[]> veggiesUpdate01 = new List<GameObject[]>();
    List<GameObject[]> veggiesUpdate02 = new List<GameObject[]>();
    private bool veggiesUPHappened02 = false;
    private bool veggiesUPHappened01 = false;

    List<GameObject[]> insectsUpdate01 = new List<GameObject[]>();
    List<GameObject[]> insectsUpdate02 = new List<GameObject[]>();
    private bool insectsUPHappened02 = false;
    private bool insectsUPHappened01 = false;

    List<GameObject[]> algaeUpdate01 = new List<GameObject[]>();
    List<GameObject[]> algaeUpdate02 = new List<GameObject[]>();
    private bool algaeUPHappened02 = false;
    private bool algaeUPHappened01 = false;

    List<GameObject[]> energyUpdate01 = new List<GameObject[]>();
    List<GameObject[]> energyUpdate02 = new List<GameObject[]>();
    private bool energyUPHappened02 = false;
    private bool energyUPHappened01 = false;

    List<GameObject[]> wasteUpdate01 = new List<GameObject[]>();
    List<GameObject[]> wasteUpdate02 = new List<GameObject[]>();
    List<GameObject[]> wasteUpdate03 = new List<GameObject[]>();
    private bool wasteUPHappened03 = false;
    private bool wasteUPHappened02 = false;
    private bool wasteUPHappened01 = false;

    List<int> upgradeToAction = new List<int>();
    int removed = 0;

    public TradeOffDescriptor poultry_simple;
    private bool purchasable = false;
    // Start is called before the first frame update
    
    void Start() 
    {
        upgradeList = new List<GameObject[]>() { ChickenUpgrade01,ChickenUpgrade02,ChickenUpgrade03,VeggiesUpgrade01,
            VeggiesUpgrade02,VeggiesUpgrade03,InsectsUpgrade01,InsectsUpgrade02,InsectsUpgrade03,
            AlgaeUpgrade01,AlgaeUpgrade02,AlgaeUpgrade03,EnergyUpgrade01,EnergyUpgrade02,
            EnergyUpgrade03,WasteUpgrade01,WasteUpgrade02,WasteUpgrade03};
        upgradeToAction = new List<int>() { 1, 2, -1, 3, 4, -1, 5, 6, -1, 7, 8, -1, 9, 10, -1, 11, 12, 13 };
        if(upgradeToAction.Count != upgradeList.Count)
        {
            Debug.LogError("the list of the updates to actions should have the same elements as the upgrade lists!");
        }

        chickenUpdate01 = new List<GameObject[]>() { ChickenUpgrade01, ChickenPlus01 };
        chickenUpdate02 = new List<GameObject[]>() { ChickenUpgrade02, ChickenPlus02 };

        veggiesUpdate01 = new List<GameObject[]>() { VeggiesUpgrade01, VeggiesPlus01 };
        veggiesUpdate02 = new List<GameObject[]>() { VeggiesUpgrade02, VeggiesPlus02 };

        algaeUpdate01 = new List<GameObject[]>() { AlgaeUpgrade01, AlgaePlus01 };
        algaeUpdate02 = new List<GameObject[]>() { AlgaeUpgrade02, AlgaePlus02 };

        energyUpdate01 = new List<GameObject[]>() { EnergyUpgrade01, EnergyPlus01 };
        energyUpdate02 = new List<GameObject[]>() { EnergyUpgrade02, EnergyPlus02 };

        wasteUpdate01 = new List<GameObject[]>() { WasteUpgrade01, WastePlus02 };
        wasteUpdate02 = new List<GameObject[]>() { WasteUpgrade02, WastePlus03 };
        wasteUpdate03 = new List<GameObject[]>() { WasteUpgrade03, WastePlus04 };

        
        upgradeActions = new List<GameObject[]>() { ChickenUpgrade01,ChickenUpgrade02,ChickenUpgrade03,VeggiesUpgrade01,
            VeggiesUpgrade02,VeggiesUpgrade03,InsectsUpgrade01,InsectsUpgrade02,InsectsUpgrade03,
            AlgaeUpgrade01,AlgaeUpgrade02,AlgaeUpgrade03,EnergyUpgrade01,EnergyUpgrade02,
            EnergyUpgrade03,WasteUpgrade01,WasteUpgrade02,WasteUpgrade03};

        buttonList = new List<GameObject[]>() {ChickenManual,ChickenPlus01,ChickenPlus02,VeggiesManual,VeggiesPlus01,VeggiesPlus02,
            InsectsManual,InsectsPlus01,InsectsPlus02,AlgaeManual,AlgaePlus01,AlgaePlus02,EnergyManual,EnergyPlus01,EnergyPlus02,
            WasteManual,WastePlus01,WastePlus02,WastePlus03,WastePlus04,WastePlus05,WastePlus06,WastePlus07};
        

        buttonActions = new List<GameObject[]>() {ChickenManual,VeggiesManual,InsectsManual,AlgaeManual,EnergyManual,WasteManual};

        AllActions.AddRange(buttonActions);
        AllActions.AddRange(upgradeActions);



        if (derender) DerrenderCanvasandCameras();
        
        importantVariables = GameObject.FindObjectsOfType<Amount>();
        //poultry_simple = GameObject.Find("TradeDescriptorDiv (Click) Poultry (1) (produce manual)").GetComponent<TradeOffDescriptor>();

        TradeOffDescriptor[] trades = GameObject.FindObjectsOfType<TradeOffDescriptor>();
        UpgradeDescriptor[] upgrades = GameObject.FindObjectsOfType<UpgradeDescriptor>();
        
        //foreach (var up in upgradeList)
        //{
        //    foreach (var item in up)
        //    {
        //        foreach (var button in buttonList)
        //        {
        //            foreach (var it in button)
        //            {                   
        //                if (it.name.Split(')').Length > 1)
        //                {
        //                    var importVal = it.name.Split(')')[1];
        //                    if (importVal == "") continue;
        //                    if (item.GetComponent<UpButton>() != null)
        //                    {
        //                        if (item.GetComponent<UpButton>().prodButtLock.transform.parent.name.Contains(importVal))
        //                        {

        //                            print(it.name.Split(')')[1] + " and " + item.GetComponent<UpButton>().prodButtLock.transform.parent.name);
        //                            //print(item.transform.parent.name + " the chicken upgrade 01 is" + button.name);
        //                        }
        //                        if (item.transform.parent.name == it.name)
        //                        {
        //                            print(item.GetComponent<UpButton>().prodButtLock.name + "and prod name match");
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}
    }

    // Update is called once per frame
    void Update()
    {
        // main loop of changing action.
        int actionUsed = Random.Range(0, AllActions.Count);
        //actionUsed = actionUsed  - buttonActions.Count;
        var action = AllActions[actionUsed];
        purchasable = true;
        if (upgradeActions.Contains(action))
        {
            var tmp = action[0];
            action[0] = action[1];
            action[1] = tmp;
        }

        foreach(GameObject obj in action)
        {
            if (obj.GetComponent<TradeOffDescriptor>() != null)
            {
                TradeOffDescriptor trade = obj.GetComponent<TradeOffDescriptor>();
                foreach (var item in trade.requirements)
                {
                    item.VerifyIsPurchasable();
                    if (!item.isPurchasable)
                    {
                        purchasable = false;
                        break;
                    }
                }
                if (purchasable)
                {
                    trade.ExecuteElementsTrade();
                }
                else
                {
                    break;
                }
            }
            else if (obj.GetComponent<PriceMultiplier>() != null)
            {
                obj.GetComponent<PriceMultiplier>().ApplyMultiplication();
            }
            else if(obj.GetComponent<AmountSimple>() != null)
            {
                obj.GetComponent<AmountSimple>().AddOne();
            }
            else if(obj.GetComponent<CattleSmallCatac>() != null)
            {
                obj.GetComponent<CattleSmallCatac>().CheckThresholds();
            }


            // If none of these are true, then it is an upgrade
            else if(obj.GetComponent<UpButton>() != null)
            {
                obj.GetComponent<UpButton>().UnlockProduct();
            }
            else if(obj.GetComponent<AutoAgroecology>() != null)
            {
                obj.GetComponent<AutoAgroecology>().ActivateAgroecology();
            }
            else if(obj.GetComponent<PolicyManager>() != null)
            {
                obj.GetComponent<PolicyManager>().Schedule();
            }
            else if(obj.GetComponent<UpgradeBlocker>() != null)
            {
                obj.GetComponent<UpgradeBlocker>().BlockUpgrade();
            }
            else if(obj.GetComponent<TradeOffElemsActivator>() != null)
            {
                obj.GetComponent<TradeOffElemsActivator>().ActivateElems();
            }
            else if(obj.GetComponent<UpgradeDescriptor>() != null)
            {
                UpgradeDescriptor trade = obj.GetComponent<UpgradeDescriptor>();
                foreach (var item in trade.requirements)
                {
                    item.VerifyIsPurchasable();
                    if (!item.isPurchasable)
                    {
                        purchasable = false;
                        break;
                    }
                }
                if (purchasable)
                {
                    trade.ExecuteUpRequirements();
                }
                else
                {
                    break;
                }
            }
            else if(obj.GetComponent<AgroecologyManager>() != null)
            {
                if (action.SequenceEqual(AlgaeUpgrade02))
                {
                    obj.GetComponent<AgroecologyManager>().DeactivateTwo();
                }
                else if(action.SequenceEqual(EnergyUpgrade03))
                {
                    obj.GetComponent<AgroecologyManager>().DeactivateOne();
                }
                else if (action.SequenceEqual(WasteUpgrade03))
                {
                    obj.GetComponent<AgroecologyManager>().DeactivateTwo();
                }
                else if (action.SequenceEqual(ChickenUpgrade01))
                {
                    obj.GetComponent<AgroecologyManager>().DeactivateOne();
                }
                else if (action.SequenceEqual(VeggiesUpgrade01))
                {
                    obj.GetComponent<AgroecologyManager>().DeactivateThree();
                }
            }

        }
        foreach (DisruptionManager cataclism in cataclisms)
        {
            if (cataclism.isActiveAndEnabled)
                cataclism.ApplyDisruption();
        }


        print(AllActions.Count);
        if (upgradeActions.Contains(action) && purchasable)
        {
            int actionIndex = upgradeActions.IndexOf(action);
            var changeAction = switchUpdate(actionIndex);
            AllActions.RemoveAt(actionUsed);
            if (changeAction != null)
            {
                for (int i = 1; i < changeAction.Count; i++)
                {
                    AllActions.Add(changeAction[i]);
                }
            }
        }



    }

    List<GameObject[]> switchUpdate(int i)
    {
        print("Using update " + i);
        switch (upgradeToAction[i])
        {
            case 1:
                return chickenUpdate01;
            case 2:
                return chickenUpdate02;
            case 3:
                return veggiesUpdate01;
            case 4:
                return veggiesUpdate02;
            case 5:
                return insectsUpdate01;
            case 6:
                return insectsUpdate02;
            case 7:
                return algaeUpdate01;
            case 8:
                return algaeUpdate02;
            case 9:
                return energyUpdate01;
            case 10:
                return energyUpdate02;
            case 11:
                return wasteUpdate01;
            case 12:
                return wasteUpdate02;
            case 13:
                return wasteUpdate03;
            default:
                return null;

        }
    }
    private void DerrenderCanvasandCameras()
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
}
