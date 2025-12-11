using System;
using UnityEngine;

namespace Core.ScriptableVariables
{
    [CreateAssetMenu(fileName = "GameObjectVariable", menuName = "Scriptable Variables/GameObject")]
    [Serializable]
    public class GameObjectVariable : ScriptableVariable<GameObject>
    {
    }
}