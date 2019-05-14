using Tobii.Gaming;
using UnityEngine;

namespace Scripts
{
    [RequireComponent(typeof(GazeAware))]
    public class GazeAwareResponseListener : MonoBehaviour
    {
        private GazeAware _gazeAware;
        public GazeAwareResponse GazeResponse;

        public bool Focused
        {
            get { return _gazeAware.HasGazeFocus; }
        }

        private void Awake()
        {
            _gazeAware = GetComponent<GazeAware>();
        }

        private void Update()
        {
            if (_gazeAware.HasGazeFocus) GazeResponse.Invoke(gameObject);
        }
    }
}