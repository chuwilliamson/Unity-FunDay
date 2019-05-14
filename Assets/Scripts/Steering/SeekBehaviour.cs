using UnityEngine;

namespace Steering
{
    public class SeekBehaviour : MonoBehaviour
    {
        public float MAX_SPEED = 5;
        public Transform Target;
        public Vector3 Velocity = Vector3.right;

        private void Update()
        {
            var desiredVelocity = Target.position - transform.position;
            Velocity += desiredVelocity;

            if (Velocity.magnitude > MAX_SPEED)
                Velocity = Velocity.normalized * MAX_SPEED;

            transform.position += Velocity * Time.deltaTime;
        }
    }
}