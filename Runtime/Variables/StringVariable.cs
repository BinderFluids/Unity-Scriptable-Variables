using System;
using UnityEngine;

namespace ScriptableVariables
{
    [CreateAssetMenu(fileName = "StringVariable", menuName = "Scriptable Variables/String")]
    [Serializable]
    public class StringVariable : ScriptableVariable<string>
    {
    }
}