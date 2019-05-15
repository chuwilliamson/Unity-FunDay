using CrossPlatformDevelopment.Variables;
using Tobii.Gaming;
using UnityEngine;

public class TobiiMonitorBehaviour : MonoBehaviour
{
    [SerializeField] private Vector2Variable EyePosition;

    [SerializeField] private StringVariable FocusedObject;

    public string info;

    // Update is called once per frame
    private void Update()
    {
        var focused = TobiiAPI.GetFocusedObject();
        if (focused != null)
            FocusedObject.Value = focused.name;
        EyePosition.Value = TobiiAPI.GetGazePoint().Screen;
    }
}