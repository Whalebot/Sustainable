using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class ActionSO : ScriptableObject
{
    [TabGroup("Cost")]
    [Header("Cost")]
    [InlineProperty] public Ressources cost;

    [TabGroup("Result")]
    [Header("Result")]
    [InlineProperty] public Ressources result;
}
