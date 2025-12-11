using System;
using UnityEngine;

namespace Core.ScriptableVariables
{
    [CreateAssetMenu(fileName = "IntVariable", menuName = "Scriptable Variables/Int")]
    [Serializable]
    public class IntVariable : ScriptableVariable<int>
    {
    }
}