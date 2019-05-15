using UnityEngine;

namespace CrossPlatformDevelopment
{
    public class SetVariableBehaviour : MonoBehaviour
    {
        [SerializeField]
        private Variables.Vector2Variable mousePositionVariable;

        // Update is called once per frame
        private void Update()
        {
            mousePositionVariable.Value = Input.mousePosition;
        }
    }
}