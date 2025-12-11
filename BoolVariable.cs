using System;
using UnityEngine;

namespace Core.ScriptableVariables
{
    [CreateAssetMenu(fileName = "BoolVariable", menuName = "Scriptable Variables/Bool")]
    [Serializable]
    public class BoolVariable : ScriptableVariable<bool>
    {
    }
}