using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class AI : MonoBehaviour
{
    public UpgradeSO upgradeGoal;
    public ActionSO nextAction;
    public AIBehaviour[] bots;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    [Button]
    public void CalculateNextAction()
    {
        //Check if AI can afford next upgrade, if yes, next action is buying the upgrade.
        if (GameManager.Instance.CheckRessources(upgradeGoal.cost))
        {
            nextAction = upgradeGoal;
        }
        //Check what ressources the AI is missing
        else
        {
            print("Searching for next action");
            bool[] temp = GameManager.Instance.FindMissingRessources(upgradeGoal.cost);
            //0 energy;
            //1 food;
            //2 waste;
            //3 foodShortage;
            //4 approval;
            //5 population;
            //6 money;
            //7 pollution;
            //8 bees;
            //9 naturalCapital;
            if (temp[0])
            {
                print("Find energy");
            }
            else if (temp[1])
            {
                print("Find food");
            }
            else if (temp[2])
            {
                print("Find waste");
            }
            else if (temp[3])
            {
                print("Find foodShortage");
            }
            else if (temp[4])
            {
                print("Find approval");
            }
            else if (temp[5])
            {
                print("Find population");
            }
            else if (temp[6])
            {
                print("Find money");
            }

            else if (temp[7])
            {
                print("Find pollution");
            }
            else if (temp[8])
            {
                print("Find bees");
            }
            else if (temp[9])
            {
                print("Find naturalCapital");
            }
            else print("ERROR: Can afford everything");
        }

    }

    public void CalculateOptimalProductionMethod()
    {
        //Optimize for money
        List<ProductionSO> validProductions = new List<ProductionSO>();
        ProductionSO bestProduction = null;
        for (int i = 0; i < validProductions.Count; i++)
        {
            if (bestProduction == null)
            {
                bestProduction = validProductions[i];
                continue;
            }
            int gained = validProductions[i].result.money - validProductions[i].cost.money;
            if (gained > bestProduction.result.money - bestProduction.cost.money) bestProduction = validProductions[i];
        }
    }

}
