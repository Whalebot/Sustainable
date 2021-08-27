using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class FoodManager : BaseFacility
{
    public static FoodManager Instance { get; private set; }
    public float foodMultiplier = 1;
    public List<ProductionSO> productionTypes;
    public List<ProductionSO> unlockedIndustrialProductionTypes;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        TimeManager.Instance.advanceGameEvent += AdvanceGameState;
    }



    //Executes the production and updates game state
    [Button]
    public void ExecuteProduction(ProductionSO p)
    {
        if (!GameManager.Instance.CheckRessources(p.cost))
        {
            print("Can't afford production " + p.name);
            return;
        }
        GameManager.Instance.SubtractRessources(p.cost);
        Ressources tempRessource = new Ressources();
        GameManager.Instance.SetRessources(p.result, tempRessource);
        tempRessource.food = (int)(tempRessource.food * foodMultiplier);

        GameManager.Instance.AddRessources(tempRessource);
        GameManager.Instance.updateGameState?.Invoke();
    }

    //Does not update game state
    public void ExecuteAutomaticProduction(ProductionSO p)
    {
        if (!GameManager.Instance.CheckRessources(p.cost))
        {
            print("Can't afford production " + p.name);
            return;
        }
        GameManager.Instance.SubtractRessources(p.cost);
        Ressources tempRessource = new Ressources();
        GameManager.Instance.SetRessources(p.result, tempRessource);
        tempRessource.food = (int)(tempRessource.food * foodMultiplier);

        GameManager.Instance.AddRessources(tempRessource);
    }

    public override void AdvanceGameState()
    {
        base.AdvanceGameState();
        foreach (var item in unlockedIndustrialProductionTypes)
        {
            ExecuteAutomaticProduction(item);
        }
    }
}
