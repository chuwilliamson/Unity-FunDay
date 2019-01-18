using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownBehaviour : MonoBehaviour
{

    public float offset;
    public float yScale;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    Vector3 newPosition = new Vector3(transform.position.x,
	       yScale * Mathf.Cos(Time.realtimeSinceStartup) + offset,
	        transform.position.z);

	    transform.position = newPosition;
    }
}
