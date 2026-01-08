using UnityEngine;

namespace ScriptableVariables
{
    [CreateAssetMenu(fileName = "FloatVariable", menuName = "Scriptable Variables/Float")]
    public class FloatVariable : ScriptableVariable<float>
    {
        public void ChangeValue(float amt)
        {
            Value += amt; 
        }
    }
}