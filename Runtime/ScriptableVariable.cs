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
            OnValueChanged?.Invoke(value = initialValue);
        }
    }
}