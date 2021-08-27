using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using Sirenix.OdinInspector;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public bool disableGraphics;
    [TabGroup("Ressources")]
    [InlineProperty] public Ressources ressources;
    [TabGroup("Start Ressources")]
    [InlineProperty] public Ressources startRessources;

    public delegate void GameEvent();
    public GameEvent updateGameState;

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

    public int Energy
    {
        get
        {
            return ressources.energy;
        }
        set
        {
            ressources.energy = value;
        }
    }
    public int Food
    {
        get
        {
            return ressources.food;
        }
        set
        {
            ressources.food = value;
        }
    }
    public int Waste
    {
        get
        {
            return ressources.waste;
        }
        set
        {
            ressources.waste = value;
        }
    }
    public int FoodShortage
    {
        get
        {
            return ressources.foodShortage;
        }
        set
        {
            ressources.foodShortage = value;
        }
    }
    public int Approval
    {
        get
        {
            return ressources.approval;
        }
        set
        {
            ressources.approval = value;
        }
    }
    public int Population
    {
        get
        {
            return ressources.population;
        }
        set
        {
            ressources.population = value;
        }
    }
    public int Money
    {
        get
        {
            return ressources.money;
        }
        set
        {
            ressources.money = value;
        }
    }
    public int Pollution
    {
        get
        {
            return ressources.pollution;
        }
        set
        {
            ressources.pollution = value;
        }
    }
    public int Bees
    {
        get
        {
            return ressources.bees;
        }
        set
        {
            ressources.bees = value;
        }
    }
    public int NaturalCapital
    {
        get
        {
            return ressources.naturalCapital;
        }
        set
        {
            ressources.naturalCapital = value;
        }
    }

    [TabGroup("Deprecated")] public Amount energyAmount;
    [TabGroup("Deprecated")] public Amount foodAmount;
    [TabGroup("Deprecated")] public Amount wasteAmount;
    [TabGroup("Deprecated")] public Amount moneyAmount;
    [TabGroup("Deprecated")] public Amount approvalAmount;
    [TabGroup("Deprecated")] public Amount populationAmount;
    [TabGroup("Deprecated")] public Amount pollutionAmount;
    [TabGroup("Deprecated")] public Amount beesAmount;
    [TabGroup("Deprecated")] public Amount naturalCapitalAmount;



    private void Awake()
    {
        Instance = this;
        SetStartRessources();
    }
    // Start is called before the first frame update
    void Start()
    {
    
    }

    [Button]
    public void SetStartRessources()
    {
        energy = startRessources.energy;
        food = startRessources.food;
        waste = startRessources.waste;

        foodShortage = startRessources.foodShortage;
        approval = startRessources.approval;
        population = startRessources.population;
        money = startRessources.money;
        pollution = startRessources.pollution;
        bees = startRessources.bees;
        SetRessources(startRessources);

        //energyAmount.amountFloat = startEnergy;
        //foodAmount.amountFloat = startFood;
        //wasteAmount.amountFloat = startWaste;

        //// foodShortage = startShortage;
        //approvalAmount.amountFloat = startApproval;
        //populationAmount.amountFloat = startPopulation;
        //moneyAmount.amountFloat = startMoney;
        //pollutionAmount.amountFloat = startPollution;
        //beesAmount.amountFloat = startBees;
        //naturalCapitalAmount.amountFloat = startCapital;
    }

    public bool CheckRessources(Ressources r)
    {
        //Compare incoming ressources with available ressources and return true/false depending on whether the player has enough ressources.

        FieldInfo[] defInfo1 = ressources.GetType().GetFields();
        FieldInfo[] defInfo2 = r.GetType().GetFields();

        bool foundLackOfRessources = false;

        for (int i = 0; i < defInfo1.Length; i++)
        {
            object obj = ressources;
            object obj2 = r;

            object var1 = defInfo1[i].GetValue(obj);
            object var2 = defInfo2[i].GetValue(obj2);

            if (var1 is int)
            {
                if ((int)var2 > (int)var1) foundLackOfRessources = true;
            }
        }
        return !foundLackOfRessources;
    }

    public bool[] FindMissingRessources(Ressources r)
    {
        bool[] canAffordRessource = new bool[10];
        //Compare incoming ressources with available ressources and return true/false depending on whether the player has enough ressources.

        FieldInfo[] defInfo1 = ressources.GetType().GetFields();
        FieldInfo[] defInfo2 = r.GetType().GetFields();

        for (int i = 0; i < defInfo1.Length; i++)
        {
            object obj = ressources;
            object obj2 = r;

            object var1 = defInfo1[i].GetValue(obj);
            object var2 = defInfo2[i].GetValue(obj2);

            if (var1 is int)
            {
                if ((int)var2 > (int)var1) canAffordRessource[i] = true;
            }
        }
        return canAffordRessource;
    }


    public void SubtractRessources(Ressources r)
    {
        FieldInfo[] defInfo1 = ressources.GetType().GetFields();
        FieldInfo[] defInfo2 = r.GetType().GetFields();

        for (int i = 0; i < defInfo1.Length; i++)
        {
            object obj = ressources;
            object obj2 = r;

            object var1 = defInfo1[i].GetValue(obj);
            object var2 = defInfo2[i].GetValue(obj2);


            //ADDING VALUES
            if (var1 is int)
            {
                defInfo1[i].SetValue(obj, (int)var1 - (int)var2);
            }
        }
    }
    public void AddRessources(Ressources r)
    {
        FieldInfo[] defInfo1 = ressources.GetType().GetFields();
        FieldInfo[] defInfo2 = r.GetType().GetFields();

        for (int i = 0; i < defInfo1.Length; i++)
        {
            object obj = ressources;
            object obj2 = r;

            object var1 = defInfo1[i].GetValue(obj);
            object var2 = defInfo2[i].GetValue(obj2);


            //ADDING VALUES
            if (var1 is int)
            {

                defInfo1[i].SetValue(obj, (int)var1 + (int)var2);
            }
            else if (var1 is float)
            {
                defInfo1[i].SetValue(obj, (float)var1 + (float)var2);
            }
            else if (var1 is bool)
            {
                //SET VALUES
                if ((bool)var2)
                    defInfo1[i].SetValue(obj, defInfo2[i].GetValue(obj2));
            }
        }
    }
    public void SetRessources(Ressources r)
    {
        FieldInfo[] defInfo1 = ressources.GetType().GetFields();
        FieldInfo[] defInfo2 = r.GetType().GetFields();

        for (int i = 0; i < defInfo1.Length; i++)
        {
            object obj = ressources;
            object obj2 = r;

            object var1 = defInfo1[i].GetValue(obj);
            object var2 = defInfo2[i].GetValue(obj2);


            //ADDING VALUES
            if (var1 is int)
            {

                defInfo1[i].SetValue(obj, (int)var2);
            }
            else if (var1 is float)
            {
                defInfo1[i].SetValue(obj, (float)var2);
            }
            else if (var1 is bool)
            {
                //SET VALUES
                if ((bool)var2)
                    defInfo1[i].SetValue(obj, defInfo2[i].GetValue(obj2));
            }
        }
    }
    public void SetRessources(Ressources r, Ressources r2)
    {
        FieldInfo[] defInfo1 = r2.GetType().GetFields();
        FieldInfo[] defInfo2 = r.GetType().GetFields();

        for (int i = 0; i < defInfo1.Length; i++)
        {
            object obj = r2;
            object obj2 = r;

            object var1 = defInfo1[i].GetValue(obj);
            object var2 = defInfo2[i].GetValue(obj2);


            //ADDING VALUES
            if (var1 is int)
            {

                defInfo1[i].SetValue(obj, (int)var2);
            }
            else if (var1 is float)
            {
                defInfo1[i].SetValue(obj, (float)var2);
            }
            else if (var1 is bool)
            {
                //SET VALUES
                if ((bool)var2)
                    defInfo1[i].SetValue(obj, defInfo2[i].GetValue(obj2));
            }
        }
    }

    void Update()
    {

    }
}

[System.Serializable]
public class Ressources
{
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
}