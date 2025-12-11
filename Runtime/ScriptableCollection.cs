using System.Collections.Generic;

namespace ScriptableVariables
{
    public class ScriptableCollection<T> : RuntimeScriptableObject
    {
        public List<T> Items { get; } = new();

        public void Add(T value)
        {
            if (!Items.Contains(value))
                Items.Add(value);
        }

        public void Remove(T value)
        {
            if (Items.Contains(value))
                Items.Remove(value);
        }

        protected override void OnReset()
        {
            Items.Clear();
        }
    }
}