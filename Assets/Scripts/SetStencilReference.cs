using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStencilReference : MonoBehaviour
{
    public GameObject hideObjectsWall;
    public enum HideOptions
    {
        Outside,
        Inside
    }
    public HideOptions hideIf = HideOptions.Inside;
    public GameObject[] objectsToHide;

    private Shader _hideObjects;
    private Shader _hiddenObject;

    void Start()
    {
        if(hideIf == HideOptions.Outside)
        {
            _hiddenObject = Shader.Find("Custom/HideObjects/HideObjectIfOutside");
        }
        else
        {
            _hiddenObject = Shader.Find("Custom/HideObjects/HideObjectIfInside");
        }

        _hideObjects = Shader.Find("Custom/HideObjects/HideObjectsWall");


        if (_hiddenObject == null || _hideObjects == null )
        {
            Debug.Log("Shaders not found!");            
        }
        else 
        {
            hideObjectsWall.GetComponent<Renderer>().material.shader = _hideObjects;
            hideObjectsWall.GetComponent<Renderer>().material.SetInt("_StencilRef", 3);

            for (int i = 0; i < objectsToHide.Length; i++)
            {
                objectsToHide[i].GetComponent<Renderer>().material.shader = _hiddenObject;
                objectsToHide[i].GetComponent<Renderer>().material.SetInt("_StencilRef", 3);
            }
        }
    }
}
