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
        [SerializeField] private UnityEvent<T> onChangeUnityEvent;
        [SerializeField] private event Action<T> onChangeEvent = delegate { }; 

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
                
                onChangeUnityEvent?.Invoke(value);
                onChangeEvent?.Invoke(value);
            }
        }
    }
}