using System;
using UnityEngine;

namespace ScriptableVariables
{
    [Serializable]
    public class ScriptableVariable<T> : RuntimeScriptableObject
    {
        [SerializeField] private T initialValue;
        [SerializeField] private T value;

        public T Value
        {
            get => value;
            set
            {
                T previousValue = this.value;
                if (Equals(previousValue, value)) return;
                
                this.value = value;
                OnValueChanged?.Invoke(value);
            }
        }

        protected void OnValidate()
        {
            OnValueChanged?.Invoke(value);
        }

        public event Action<T> OnValueChanged;

        protected override void OnReset()
        {
            value = initialValue; 
            OnValueChanged?.Invoke(value);
        }
    }
}