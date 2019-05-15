using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CrossPlatformDevelopment.Steering
{
    /// <summary>
    ///     Behaviour class that will move the agent
    /// </summary>
    public class AgentBehaviour : MonoBehaviour
    {
        [SerializeField] private List<GameObject> BombList;

        public UnityEvent OnMakeBomb;
        public float seekFactor = 5.0f;
        public GameObject SeekGameObject;

        public Transform SeekTransform;
        public Vector3 Velocity;
        public float MAX_SPEED { get; private set; }

        private void Start()
        {
            Velocity = Vector3.up;
            OnMakeBomb.AddListener(() =>
            {
                BombList.Add(Instantiate(SeekGameObject, transform.position, Quaternion.identity));
            });
        }

        // Update is called once per frame
        private void Update()
        {
            var displacement = SeekTransform.position - transform.position;
            var direction = displacement.normalized;
            Velocity += direction * seekFactor;
            transform.position += Velocity * Time.deltaTime;
            if (Velocity.magnitude > MAX_SPEED)
                Velocity = Velocity.normalized * MAX_SPEED;

            if (Input.GetKeyDown(KeyCode.Space))
                OnMakeBomb.Invoke();
        }
    }
}