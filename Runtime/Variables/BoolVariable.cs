using System;
using UnityEngine;

namespace ScriptableVariables
{
    [CreateAssetMenu(fileName = "BoolVariable", menuName = "Scriptable Variables/Bool")]
    [Serializable]
    public class BoolVariable : ScriptableVariable<bool>
    {
    }
}