using System;
using UnityEngine;
using UnityEngine.Events;

namespace Core.ScriptableVariables
{
    [Serializable]
    public class VariableReference<T>
    {
        [SerializeField] private ScriptableVariable<T> Variable;
        [SerializeField] private UnityEvent<T> OnChange;

        public T Value
        {
            get => Variable.Value;
            set => Variable.Value = value;
        }
    }
}