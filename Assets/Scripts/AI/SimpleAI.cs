using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Enums;

public class SimpleAI : MonoBehaviour
{
    public BotTypes bottype = BotTypes.Nada;
    public UiReferencer uiReferencer;
    public Amount population;
    public Amount food;
    public Amount money;
    public Amount energy;
    public Amount waste;
    public float counter;
    public float timeSpeed = 1;
    public bool isAIActive;
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
    public BotData bot = new BotData();



    public float waitSeconds = 3;
    private float timer = 0;

    List<int> upgradeToAction = new List<int>();
    int removed = 0;

    public TradeOffDescriptor poultry_simple;
    // Start is called before the first frame update
    private CattleSmallCatac[] cataclismManagers;
    private int totSum;
    private int totUsers = 5;
    private int[] array_Act_using;
    private int[] array_Upg_Using;
    private float timeSinceStart = 0;
    private int changeTimeEvery = 5;
    private int changeTimer = 5;
    private int timeZone = 1;
    private List<int[]> currentBotActions = new List<int[]>();
    private List<int[]> currentBotUpgrade = new List<int[]>();
    private List<float> currentBottimers = new List<float>();
    private List<int> toUpgrade = new List<int>();
    private List<int> manualActionsIndex = new List<int>() { 0,3,6,9,12,15 };
    private bool hasActivated = false;

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

        chickenUpdate01 = new List<GameObject[]>() { ChickenPlus01 };
        chickenUpdate02 = new List<GameObject[]>() { ChickenPlus02 };

        veggiesUpdate01 = new List<GameObject[]>() { VeggiesPlus01 };
        veggiesUpdate02 = new List<GameObject[]>() { VeggiesPlus02 };

        insectsUpdate01 = new List<GameObject[]>() { InsectsPlus01 };
        insectsUpdate02 = new List<GameObject[]>() { InsectsPlus02 };

        algaeUpdate01 = new List<GameObject[]>() { AlgaePlus01 };
        algaeUpdate02 = new List<GameObject[]>() { AlgaePlus02 };

        energyUpdate01 = new List<GameObject[]>() { EnergyPlus01 };
        energyUpdate02 = new List<GameObject[]>() { EnergyPlus02 };

        wasteUpdate01 = new List<GameObject[]>() { WastePlus02 };
        wasteUpdate02 = new List<GameObject[]>() { WastePlus03 };
        wasteUpdate03 = new List<GameObject[]>() { WastePlus04 };

        
        

        buttonList = new List<GameObject[]>() {ChickenManual,ChickenPlus01,ChickenPlus02,VeggiesManual,VeggiesPlus01,VeggiesPlus02,
            InsectsManual,InsectsPlus01,InsectsPlus02,AlgaeManual,AlgaePlus01,AlgaePlus02,EnergyManual,EnergyPlus01,EnergyPlus02,
            WasteManual,WastePlus01,WastePlus02,WastePlus03,WastePlus04};

        bot.AssignBotValues(bottype);

        

        cataclismManagers = GameObject.FindObjectsOfType<CattleSmallCatac>();
        // things have to be enabled for the game to work.
        if (derender) DerrenderCanvasandCameras();
        
        importantVariables = GameObject.FindObjectsOfType<Amount>();

        TradeOffDescriptor[] trades = GameObject.FindObjectsOfType<TradeOffDescriptor>();
        UpgradeDescriptor[] upgrades = GameObject.FindObjectsOfType<UpgradeDescriptor>();
        
    }

    private void AssignVariables()
    {
        currentBotActions = new List<int[]>() {bot.ProbsActBot01_05, bot.ProbsActBot01_10, bot.ProbsActBot01_15,
            bot.ProbsActBot01_20, bot.ProbsActBot01_25, bot.ProbsActBot01_30, bot.ProbsActBot01_3x };
        currentBotUpgrade = new List<int[]>() {bot.ProbsUpgBot01_05, bot.ProbsUpgBot01_10, bot.ProbsUpgBot01_15,
            bot.ProbsUpgBot01_20, bot.ProbsUpgBot01_25, bot.ProbsUpgBot01_30, bot.ProbsUpgBot01_3x };
        currentBottimers = new List<float>() { bot.waitBot01_05, bot.waitBot01_10, bot.waitBot01_15,
            bot.waitBot01_20, bot.waitBot01_25, bot.waitBot01_30, bot.waitBot01_3x };
        ChangeTimeActions(timeZone);




        upgradeActions = new List<GameObject[]>() { ChickenUpgrade01,ChickenUpgrade02,ChickenUpgrade03,VeggiesUpgrade01,
            VeggiesUpgrade02,VeggiesUpgrade03,InsectsUpgrade01,InsectsUpgrade02,InsectsUpgrade03,
            AlgaeUpgrade01,AlgaeUpgrade02,AlgaeUpgrade03,EnergyUpgrade01,EnergyUpgrade02,
            EnergyUpgrade03,WasteUpgrade01,WasteUpgrade02,WasteUpgrade03};

        buttonActions = new List<GameObject[]>() { ChickenManual, VeggiesManual, InsectsManual, AlgaeManual, EnergyManual, WasteManual, WastePlus01 };

        AllActions.AddRange(buttonActions);
        AllActions.AddRange(upgradeActions);
    }

    public int SumArray(int[] toBeSummed)
    {
        int sum = 0;
        foreach (int item in toBeSummed)
        {
            sum += item;
        }
        return sum;
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceStart += Time.deltaTime;
        if (isAIActive)
        {
            if (!hasActivated)
            {
                AssignVariables();
                hasActivated = true;
            }
            Time.timeScale = timeSpeed;
            timer += Time.deltaTime;
        }
        if(timeSinceStart/60 > changeTimer && timeZone<currentBottimers.Count())
        {
            print("time is changing at " + changeTimer);
            timeZone += 1;
            ChangeTimeActions(timeZone);
            changeTimer = changeTimeEvery * timeZone; // Assumes that every time slot is the same. 
        }
        if (timer > waitSeconds)
        {
            // main loop of changing action.
            // TODO: Modify the sample so the game samples from update and actions independently, but the main loop stays the same. This means
            // that the all actions is still take n into account, but a loop checking if the action taken is legalk has to be implemented.
            // the way to sample is: a loop will be created, in this loop the a random number will be created (outside of the loop) and then the values
            // of the actions will be compared to this one, if the value is 0, then next, if not zero and less than the given value, then is chosen, given that is in the all actions.
            
            bool hasupgrade = false;
            int actionUsed;
            int upg = -100;
            GameObject[] action;
            bool wasteforced = false;
            bool energyforced = false;
            if (money.amountFloat < 20 * timeZone)
            {
                wasteforced = true;
                actionUsed = 15;
                action = buttonList[actionUsed];
            }
            else if (population.amountFloat * 2.5f > food.amountFloat)
            {
                energyforced = true;
                bool checkPurchasable = true;
                actionUsed = 3;
                foreach (GameObject obj in buttonList[actionUsed])
                {
                    if (obj.GetComponent<TradeOffDescriptor>() != null)
                    {
                        TradeOffDescriptor trade = obj.GetComponent<TradeOffDescriptor>();
                        foreach (var item in trade.requirements)
                        {
                            item.VerifyIsPurchasable();
                            if (!item.isPurchasable)
                            {
                                checkPurchasable = false;
                            }
                        }
                    }
                }
                if (!checkPurchasable) actionUsed = 12;
                action = buttonList[actionUsed];
            }else if(energy.amountFloat < 30 * timeZone)
            {
                wasteforced = true;
                actionUsed = 12;
                action = buttonList[actionUsed];
            }
            else if(waste.amountFloat > 500 * timeZone)
            {
                wasteforced = true;
                actionUsed = 15;
                action = buttonList[actionUsed];
            }
            else if (energy.amountFloat < 20 * timeZone) {
                energyforced = true;
                actionUsed = 12;
                action = buttonList[actionUsed];
            } else
            {
                float randomType = Random.Range(0.0f, 1.0f);
                if (randomType < 0.3 && toUpgrade.Count > 0)
                {
                    hasupgrade = true;
                    upg = Random.Range(0, toUpgrade.Count);
                    actionUsed = toUpgrade[upg];
                    action = upgradeActions[actionUsed];
                }
                else if (randomType < 0.5)
                {
                    int index = 0;
                    int countLoops = 0;
                    while (manualActionsIndex.Contains(index) && countLoops < 10000)
                    {
                        int probCounter = 0;
                        index = 0;
                        int random = Random.Range(0, totSum);
                        foreach (int item in array_Act_using)
                        {
                            if (item == 0) { index++; continue; }
                            probCounter += item;
                            if (random < probCounter) break;
                            index++;
                        }
                        countLoops++;
                    }
                    actionUsed = index;
                    if (population.amountFloat * 2.5f > food.amountFloat && energy.amountFloat < 30)
                    {
                        bool checkPurchasable = true;
                        foreach (GameObject obj in buttonList[actionUsed])
                        {
                            if (obj.GetComponent<TradeOffDescriptor>() != null)
                            {
                                TradeOffDescriptor trade = obj.GetComponent<TradeOffDescriptor>();
                                foreach (var item in trade.requirements)
                                {
                                    item.VerifyIsPurchasable();
                                    if (!item.isPurchasable)
                                    {
                                        checkPurchasable = false;
                                    }
                                }
                            }
                        }
                        print("action used " + buttonList[actionUsed][0].name);
                        if (!checkPurchasable) actionUsed = 12;
                    }
                    action = buttonList[actionUsed];
                    if (!AllActions.Contains(action))
                    {
                        return;
                    }

                }
                else
                {
                    int random = Random.Range(0, totSum);
                    int probCounter = 0;
                    int index = 0;
                    foreach (int item in array_Act_using)
                    {
                        if (item == 0) { index++; continue; }
                        probCounter += item;
                        if (random < probCounter) break;
                        index++;
                    }
                    actionUsed = index;
                    if (population.amountFloat * 2.5f > food.amountFloat && energy.amountFloat < 30)
                    {
                        bool checkPurchasable = true;
                        foreach (GameObject obj in buttonList[actionUsed])
                        {
                            if (obj.GetComponent<TradeOffDescriptor>() != null)
                            {
                                TradeOffDescriptor trade = obj.GetComponent<TradeOffDescriptor>();
                                foreach (var item in trade.requirements)
                                {
                                    item.VerifyIsPurchasable();
                                    if (!item.isPurchasable)
                                    {
                                        checkPurchasable = false;
                                    }
                                }
                            }
                        }
                        print("action used " + buttonList[actionUsed][0].name);
                        if (!checkPurchasable) actionUsed = 12;
                    }
                    action = buttonList[actionUsed];
                    if (!AllActions.Contains(action))
                    {
                        return;
                    }
                }
            }
            foreach (GameObject obj in action)
            {
                if (obj.GetComponent<TradeOffDescriptor>() != null)
                {
                    TradeOffDescriptor trade = obj.GetComponent<TradeOffDescriptor>();
                    foreach (var item in trade.requirements)
                    {
                        item.VerifyIsPurchasable();
                        if (!item.isPurchasable)
                        {
                            return;
                        }
                    }
                }
                else if (obj.GetComponent<UpgradeDescriptor>() != null)
                {
                    UpgradeDescriptor trade = obj.GetComponent<UpgradeDescriptor>();
                    foreach (var item in trade.requirements)
                    {
                        item.VerifyIsPurchasable();
                        if (!item.isPurchasable)
                        {
                            return;
                        }
                    }
                }
                else if (obj.GetComponent<SmallScaleLimitManager>() != null)
                {
                    var limitManager = obj.GetComponent<SmallScaleLimitManager>();
                    if (limitManager.amountSimple.simpleAmount >= limitManager.limit)
                    {
                        limitManager.limitButtonOff.gameObject.SetActive(true);
                        return;
                    }
                }
            }
            if (!(energyforced || wasteforced)) timer = 0;
            if (hasupgrade) toUpgrade.RemoveAt(upg);
            
            TakeAction(action);
            
            foreach (DisruptionManager cataclism in cataclisms)
            {
                if (cataclism.isActiveAndEnabled)
                {
                    cataclism.ApplyDisruption();
                    cataclism.gameObject.SetActive(false);
                    cataclism.succWin.gameObject.SetActive(false);
                    cataclism.failedWin.gameObject.SetActive(false);
                    foreach(var item in cataclismManagers)
                    {
                        item.firstCataclysmWindow.SetActive(false);
                        item.secondCataclysmWindow.SetActive(false);
                        item.secondPreventionWindow.SetActive(false);
                        item.failedPanel.SetActive(false);
                        item.failedWindow.SetActive(false);
                        item.succeededPanel.SetActive(false);
                        item.succeededWindow.SetActive(false);
                        item.preventedCataclysmWindow.SetActive(false);
                    }
                }
            }
            if (upgradeActions.Contains(action))
            {
                int allIndex = AllActions.IndexOf(action);
                int actionIndex = upgradeActions.IndexOf(action);
                var changeAction = switchUpdate(actionIndex);
                if (allIndex == -1)
                {
                    AllActions.RemoveAt(allIndex);
                }
                if (changeAction != null)
                {
                    for (int i = 0; i < changeAction.Count; i++)
                    {
                        AllActions.Add(changeAction[i]);
                    }
                }
            }
        }
    }
    void TakeAction(GameObject[] action)
    {
        foreach (GameObject obj in action)
        {
            if (obj.GetComponent<TradeOffDescriptor>() != null)
            {
                TradeOffDescriptor trade = obj.GetComponent<TradeOffDescriptor>();
                trade.ExecuteElementsTrade();

            }
            else if (obj.GetComponent<PriceMultiplier>() != null)
            {
                obj.GetComponent<PriceMultiplier>().ApplyMultiplication();
            }
            else if (obj.GetComponent<AmountSimple>() != null)
            {
                obj.GetComponent<AmountSimple>().AddOne();
            }
            else if (obj.GetComponent<CattleSmallCatac>() != null)
            {
                obj.GetComponent<CattleSmallCatac>().CheckThresholds();
            }


            // If none of these are true, then it is an upgrade
            else if (obj.GetComponent<UpButton>() != null)
            {
                obj.GetComponent<UpButton>().UnlockProduct();
            }
            else if (obj.GetComponent<AutoAgroecology>() != null)
            {
                obj.GetComponent<AutoAgroecology>().ActivateAgroecology();
            }
            else if (obj.GetComponent<PolicyManager>() != null)
            {
                obj.GetComponent<PolicyManager>().Schedule();
            }
            else if (obj.GetComponent<UpgradeBlocker>() != null)
            {
                obj.GetComponent<UpgradeBlocker>().BlockUpgrade();
            }
            else if (obj.GetComponent<TradeOffElemsActivator>() != null)
            {
                obj.GetComponent<TradeOffElemsActivator>().ActivateElems();
            }
            else if (obj.GetComponent<UpgradeDescriptor>() != null)
            {
                UpgradeDescriptor trade = obj.GetComponent<UpgradeDescriptor>();
                trade.ExecuteUpRequirements();

            }
            else if (obj.GetComponent<AgroecologyManager>() != null)
            {
                if (action.SequenceEqual(AlgaeUpgrade02))
                {
                    obj.GetComponent<AgroecologyManager>().DeactivateTwo();
                }
                else if (action.SequenceEqual(EnergyUpgrade03))
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
    }
    void ChangeTimeActions(int timeZ)
    {
        array_Act_using = currentBotActions[timeZ - 1];
        array_Upg_Using = currentBotUpgrade[timeZ - 1];
        waitSeconds = currentBottimers[timeZ - 1]/2;
        // TODO: might change this to own function.
        totSum = SumArray(array_Act_using);
        int index = 0;
        foreach (var item in array_Upg_Using)
        {

            if (item == 0) { index++; continue; }
            int random = Random.Range(0, totUsers);
            if (random < item) toUpgrade.Add(index);
            index++;
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
