using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownBehaviour : MonoBehaviour {

    public float offset;
    public float yscale;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 newposition 
            = new Vector3(transform.position.x, 
            yscale * Mathf.Cos(Time.realtimeSinceStartup) + offset,
            transform.position.z);
        transform.position = newposition;
	}
}
