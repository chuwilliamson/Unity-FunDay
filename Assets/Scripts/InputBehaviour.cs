using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBehaviour : MonoBehaviour
{
    public string Result;
    // Use this for initialization

    // Update is called once per frame
    void Update()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        var inputvector = new Vector2(h, v);

        Result = inputvector.ToString();
        Debug.Log(Result);

    }
}
