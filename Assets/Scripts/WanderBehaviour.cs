using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderBehaviour : MonoBehaviour
{
    public float circleRadius;

    public float angle;

    public float circleDistance;


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        var circlePosition = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
    }
}
