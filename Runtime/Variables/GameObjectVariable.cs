using System;
using UnityEngine;

namespace ScriptableVariables
{
    [CreateAssetMenu(fileName = "GameObjectVariable", menuName = "Scriptable Variables/GameObject")]
    [Serializable]
    public class GameObjectVariable : ScriptableVariable<GameObject>
    {
    }
}