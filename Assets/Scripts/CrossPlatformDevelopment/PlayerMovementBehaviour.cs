using System.Collections;
using System.Collections.Generic;
using CrossPlatformDevelopment.Variables;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    public FloatVariable speed;
	// Use this for initialization
	// Update is called once per frame
	void Update ()
    {
        var velocity = PlayerInput.Move.normalized * speed.Value;
        transform.position += new Vector3(velocity.x, velocity.y, 0) * Time.deltaTime ;
    }
}
