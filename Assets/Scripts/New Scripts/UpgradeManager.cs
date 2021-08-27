using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public static UpgradeManager Instance { get; private set; }
    public List<UpgradeSO> allUpgrades;
    public List<ProductionSO> allProduction;
    public List<ProductionSO> availableProduction;
    public List<UpgradeSO> obtainedUpgrades;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public int CheckUpgradeNumber(UpgradeSO p) {
        int upgradeNumber = 0;
        foreach (var item in obtainedUpgrades)
        {
            if (item == p) upgradeNumber++;
        }
        return upgradeNumber;
    }

    //Does not update game state
    public void UnlockUpgrade(UpgradeSO p)
    {
        if (!GameManager.Instance.CheckRessources(p.cost))
        {
            print("Can't afford upgrade " + p.name);
            return;
        }

        obtainedUpgrades.Add(p);
        GameManager.Instance.SubtractRessources(p.cost);
        Ressources tempRessource = new Ressources();
        GameManager.Instance.SetRessources(p.result, tempRessource);
        GameManager.Instance.AddRessources(tempRessource);
        GameManager.Instance.updateGameState?.Invoke();
    }

}
