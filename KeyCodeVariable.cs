using System;
using UnityEngine;

namespace Core.ScriptableVariables
{
    [CreateAssetMenu(fileName = "KeyCodeVariable", menuName = "Scriptable Variables/KeyCode")]
    [Serializable]
    public class KeyCodeVariable : ScriptableVariable<KeyCode>
    {
    }
}