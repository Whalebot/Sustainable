using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

   [TabGroup("Start Values")] public int startEnergy;
    [TabGroup("Start Values")] public int startFood;
    [TabGroup("Start Values")] public int startWaste;

    [TabGroup("Start Values")] public int startShortage;
    [TabGroup("Start Values")] public int startApproval;
    [TabGroup("Start Values")] public int startPopulation;
    [TabGroup("Start Values")] public int startMoney;
    [TabGroup("Start Values")] public int startPollution;
    [TabGroup("Start Values")] public int startBees;
    [TabGroup("Start Values")] public int startCapital;

    public int energy;
    public int food;
    public int waste;
    public int foodShortage;
    public int approval;
    public int population;
    public int money;
    public int pollution;
    public int bees;
    public int naturalCapital;

    public Amount energyAmount;
    public Amount foodAmount;
    public Amount wasteAmount;
    public Amount moneyAmount;
    public Amount approvalAmount;
    public Amount populationAmount;
    public Amount pollutionAmount;
    public Amount beesAmount;
    public Amount naturalCapitalAmount;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        SetStartRessources();
    }

    [Button]
    public void SetStartRessources() {
        energy = startEnergy;
        food = startFood;
        waste = startWaste;

        foodShortage = startShortage;
        approval = startApproval;
        population = startPopulation;
        money = startMoney;
        pollution = startPollution;
        bees = startBees;


        energyAmount.amountFloat = startEnergy;
        foodAmount.amountFloat = startFood;
        wasteAmount.amountFloat = startWaste;

       // foodShortage = startShortage;
        approvalAmount.amountFloat = startApproval;
        populationAmount.amountFloat = startPopulation;
        moneyAmount.amountFloat = startMoney;
        pollutionAmount.amountFloat = startPollution;
        beesAmount.amountFloat = startBees;
        naturalCapitalAmount.amountFloat = startCapital;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
