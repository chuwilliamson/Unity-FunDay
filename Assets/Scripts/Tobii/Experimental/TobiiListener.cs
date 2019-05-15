
using UnityEngine;

namespace Tobii.Experimental
{
    [RequireComponent(typeof(SphereCollider))]
    public class TobiiListener : MonoBehaviour
    {
        private SphereCollider col;
        public UnityEngine.Events.UnityEvent OnTobiiEnter;
        public UnityEngine.Events.UnityEvent OnTobiiExit;
        public float distance;
        public bool HasFocus = false;

        private void Awake()
        {
            col = GetComponent<SphereCollider>();
        }

        public float threshhold = 50;
        private bool fired = false;
        private void Update()
        {

            distance = Vector2.Distance(Camera.main.WorldToScreenPoint(transform.position),
                Tobii.Gaming.TobiiAPI.GetGazePoint().Screen);


            HasFocus = (distance <= threshhold);
            if (HasFocus)
            {
                fired = false;
                OnTobiiEnter.Invoke();
            }

            else
            {
                if (!fired)
                    OnTobiiExit.Invoke();
                fired = true;
                
            }

        }

    }
}
