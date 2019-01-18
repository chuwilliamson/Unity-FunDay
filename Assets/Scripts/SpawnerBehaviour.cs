using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehaviour : MonoBehaviour {
    public GameObject prefab;
    public List<GameObject> objects;
    int num = 5;
	// Use this for initialization
	void Start () {
        Debug.Log("Begin Spawn");
        for(int i = 0; i < num; i++)
        {
            GameObject go = Instantiate(prefab);
            objects.Add(go);
        }
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
