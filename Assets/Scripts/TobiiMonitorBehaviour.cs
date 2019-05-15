using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TobiiMonitorBehaviour : MonoBehaviour
{
    [SerializeField]
    private Variables.Vector2Variable EyePosition;
    [SerializeField]
    private Variables.StringVariable FocusedObject;

    public string info;
	// Update is called once per frame
	void Update ()
    {
        var focused = Tobii.Gaming.TobiiAPI.GetFocusedObject();
        if(focused != null)
            FocusedObject.Value = focused.name;
        EyePosition.Value = Tobii.Gaming.TobiiAPI.GetGazePoint().Screen;
    }
}
