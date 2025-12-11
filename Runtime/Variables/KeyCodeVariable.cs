using System;
using UnityEngine;

namespace ScriptableVariables
{
    [CreateAssetMenu(fileName = "KeyCodeVariable", menuName = "Scriptable Variables/KeyCode")]
    [Serializable]
    public class KeyCodeVariable : ScriptableVariable<KeyCode>
    {
    }
}