using Tobii.Gaming;
using UnityEngine;

namespace Scripts
{
    [RequireComponent(typeof(GazeAware))]
    public class GazeAwareResponseListener : MonoBehaviour
    {
        private GazeAware _gazeAware;
        public GazeAwareResponse GazeResponse;

        private void Start()
        {
            _gazeAware = GetComponent<GazeAware>();
        }

        private void Update()
        {
            if (_gazeAware.HasGazeFocus) GazeResponse.Invoke(gameObject);
        }
    }
}