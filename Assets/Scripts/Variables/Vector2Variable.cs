using UnityEngine;
using UnityEngine.Analytics;

namespace Variables
{
    [CreateAssetMenu(menuName = "Variables/Vector2")]
    public class Vector2Variable : Variable
    {
        public Vector2 _value;

        public static implicit operator Vector2Variable(Vector2 value)
        {
            var so = CreateInstance<Vector2Variable>();
            so._value = value;
            return so;
        }

        public override object Value { get; set; }
        
    }
}