using System;
using UnityEngine;

namespace ScriptableVariables
{
    [CreateAssetMenu(fileName = "IntVariable", menuName = "Scriptable Variables/Int")]
    [Serializable]
    public class IntVariable : ScriptableVariable<int>
    {
    }
}