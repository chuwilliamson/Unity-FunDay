using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

/*Chance To Spawn A Box At Different Intervals.
 The Probability/Chance Increases Over Time.
 The Interval Increases Over Time.
 
We are going to set interval to 5 initially.
probability would be .5 to spawn.
the boxes have to go away when clicked
clicking 10 cottonBoxes will progress level
when level progresses
interval decreases by 1
probability increases by .1*/
public class SpawnerBehaviour : MonoBehaviour
{

    public GameObject goodPrefab;
    public GameObject badPrefab;
    public List<GameObject> objects;

    public float countDown = 5;
    public float countDownTotal = 0;
    public float probability = .6f;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (countDown > 0)
	    {
	        countDown--;
	    }
	    else
	    {
	        if (countDownTotal < 20)
	        {
	            countDownTotal++;
	            countDown = 5;

	            float num = UnityEngine.Random.Range(0.0f, 1.0f);
	            float numRx = UnityEngine.Random.Range(0.0f, 10.0f);
	            float numRy = UnityEngine.Random.Range(0.0f, 10.0f);
	            float numRz = UnityEngine.Random.Range(0.0f, 10.0f);
            
	            GameObject go = (num <= probability) ? Instantiate(goodPrefab) : Instantiate(badPrefab);
                go.transform.position = new Vector3(numRx, numRy, numRz);
	        }
	        else
	        {
                return;
	        }


	    }
	}
}
