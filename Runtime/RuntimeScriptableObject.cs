using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableVariables
{
    [Serializable]
    public abstract class RuntimeScriptableObject : ScriptableObject
    {
        private static readonly List<RuntimeScriptableObject> Instances = new();

        private void OnEnable()
        {
            Instances.Add(this);
        }

        private void OnDisable()
        {
            Instances.Remove(this);
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void ResetAllInstances()
        {
            foreach (var instance in Instances)
                instance.OnReset();
        }

        protected abstract void OnReset();
    }
}