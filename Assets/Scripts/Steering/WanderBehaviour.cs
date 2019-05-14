using UnityEngine;

namespace Steering
{
    public class WanderBehaviour : MonoBehaviour
    {
        public float angle;

        public float circleDistance;
        public float circleRadius;


        // Use this for initialization
        private void Start()
        {
        }

        // Update is called once per frame
        private void Update()
        {
            var circlePosition = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        }
    }
}