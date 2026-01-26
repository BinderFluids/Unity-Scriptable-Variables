using System;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableVariables
{
    [Serializable]
    public class VariableReference<T>
    {
        [Tooltip("Variable to reference. Leave empty to use constant value.")]
        [SerializeField] private ScriptableVariable<T> Variable;
        
        [Tooltip("Constant value to use. Only in use if scriptable variable is empty.")]
        [SerializeField] private T value; 
        [SerializeField] private UnityEvent<T> OnChange;

        public T Value
        {
            get
            {
                if (Variable != null) return Variable.Value;
                return value;
            }
            set
            {
                if (Variable != null) Variable.Value = value;
                this.value = value;
            }
        }
    }
}