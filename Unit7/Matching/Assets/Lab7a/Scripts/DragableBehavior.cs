using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragableBehavior : MonoBehaviour
{
    private Camera cameraObj;
    public bool draggable;
    void Start()
    {
        cameraObj = Camera.main;
    }
    public IEnumerator OnMouseDown()
    {
        draggable = true;
        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            Debug.Log("drag");
        }
    }
    public void OnMouseUp()
    {
        draggable = false;
    }
}
