using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[CreateAssetMenu(fileName = "New Production Method", menuName = "Production")]
public class ProductionSO : ScriptableObject
{
    public ProductionMethod productionMethod;
    public Ressources cost;
    public Ressources result;

    public enum ProductionMethod { 
    SmallScale, Industrial, Agroecology
    }
}
