using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[CreateAssetMenu(fileName = "New Production Method", menuName = "Production")]
public class ProductionSO : ActionSO
{
    public ProductionMethod productionMethod;

    public enum ProductionMethod { 
    SmallScale, Industrial, Agroecology
    }
}
