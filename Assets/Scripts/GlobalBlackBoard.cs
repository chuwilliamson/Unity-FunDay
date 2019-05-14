using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu]
public class GlobalBlackBoard : ScriptableObject
{
    public Dictionary<GameObject, Color> ColorUndoDictionary;

    public void PrintInfo(string value)
    {
        Debug.Log(value);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    public void SetColor(GameObject go)
    {
        var mat = go.GetComponent<MeshRenderer>().material;
        ColorUndoDictionary.Add(go, mat.color);
        mat.color = Color.green;
    }

    public void RevertColor(GameObject go)
    {
        Color color;
        if (ColorUndoDictionary.TryGetValue(go, out color))
        {
            var mat = go.GetComponent<MeshRenderer>().material;
            mat.color = color;
        }
    }
}