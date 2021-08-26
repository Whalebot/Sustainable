using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[CreateAssetMenu(fileName = "New Upgrade", menuName = "Upgrade")]
public class UpgradeSO : ActionSO
{
    public Ressources cost;
    public Ressources result;
    public ProductionSO unlockedProduction;
}
