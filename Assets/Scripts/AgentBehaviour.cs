
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Behaviour class that will move the agent
/// </summary>
public class AgentBehaviour : MonoBehaviour
{
    public Transform SeekTransform;
    public GameObject SeekGameObject;
    public Vector3 Velocity;
    public float seekFactor = 5.0f;
    public float MAX_SPEED { get; private set; }
    [SerializeField]
    private List<GameObject> BombList;

    public UnityEngine.Events.UnityEvent OnMakeBomb;

    void Start()
    {
        Velocity = Vector3.up;
        OnMakeBomb.AddListener(() =>
            {
                BombList.Add(Instantiate(SeekGameObject, transform.position, Quaternion.identity));
            });
    }

    // Update is called once per frame
    void Update()
    {
        var displacement = (SeekTransform.position - transform.position);
        var direction = displacement.normalized;
        Velocity += direction * seekFactor;
        transform.position += Velocity * Time.deltaTime;
        if (Velocity.magnitude > MAX_SPEED)
            Velocity = Velocity.normalized * MAX_SPEED;

        if (Input.GetKeyDown(KeyCode.Space))
            OnMakeBomb.Invoke();
    }
}

