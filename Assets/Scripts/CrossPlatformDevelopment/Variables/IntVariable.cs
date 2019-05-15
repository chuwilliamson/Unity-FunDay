using UnityEngine;

namespace CrossPlatformDevelopment.Variables
{
    [CreateAssetMenu(menuName = "Variables/int")]
    public class IntVariable : ScriptableObject
    {
        [SerializeField] private int value;

        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}