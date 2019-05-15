using UnityEngine;

namespace Variables
{
    [CreateAssetMenu(menuName = "Variables/String")]
    public class StringVariable : Variable
    {
        public string value;

        public override object Value
        {
            get { return value; }
            set { this.value = (string) value; }
        }
    }
}