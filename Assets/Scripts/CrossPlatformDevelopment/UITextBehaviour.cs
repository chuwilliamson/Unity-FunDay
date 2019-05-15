using CrossPlatformDevelopment.Variables;
using UnityEngine;
using UnityEngine.UI;

namespace CrossPlatformDevelopment
{
    [RequireComponent(typeof(Text))]
    public class UITextBehaviour : MonoBehaviour
    {
        [SerializeField] private Text textComponent;
        [SerializeField] private Variable displayVariable;
        

        private void Awake()
        {
            textComponent = GetComponent<Text>();
        }

        private void Update()
        {
            textComponent.text = displayVariable.ToString();
        }
    }
}