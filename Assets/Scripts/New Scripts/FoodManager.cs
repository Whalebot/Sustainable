using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class FoodManager : BaseFacility
{
    public float foodMultiplier;
    public List<ProductionSO> productionTypes;
    // Start is called before the first frame update
    void Start()
    {

    }

    [Button]
    public void ExecuteProduction(ProductionSO p)
    {
        Ressources tempRessource = new Ressources();
        GameManager.Instance.SetRessources( p.result, tempRessource);
        tempRessource.food = (int)(tempRessource.food * foodMultiplier);

        GameManager.Instance.AddRessources(tempRessource);
    }

    public override void AdvanceGameState()
    {
        base.AdvanceGameState();
    }
}
