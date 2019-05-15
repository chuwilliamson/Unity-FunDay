using UnityEngine;

namespace Variables
{
    public abstract class Variable : ScriptableObject
    {
        public abstract object Value { get; set; }

    }
}