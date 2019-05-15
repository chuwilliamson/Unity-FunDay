using UnityEngine;

namespace CrossPlatformDevelopment.Variables
{
    [CreateAssetMenu]
    public class FloatVariable : ScriptableObject
    {
        [SerializeField] private float value;

        public float Value
        {
            get { return value; }
        }
    }
}