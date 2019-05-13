

public class SeekBehaviour : UnityEngine.MonoBehaviour
{
    public UnityEngine.Transform Target;
    public UnityEngine.Vector3 Velocity = UnityEngine.Vector3.right;
    public float MAX_SPEED = 5;
    void Update()
    {
        var desiredVelocity = Target.position - transform.position;
        Velocity += desiredVelocity;

        if (Velocity.magnitude > MAX_SPEED)
            Velocity = Velocity.normalized * MAX_SPEED;

        transform.position += Velocity * UnityEngine.Time.deltaTime;

    }
}

