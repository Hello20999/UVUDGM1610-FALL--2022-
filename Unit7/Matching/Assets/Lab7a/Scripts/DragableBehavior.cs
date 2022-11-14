using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragableBehavior : MonoBehaviour
{
    private Camera cameraObj;
    public bool draggable;
    public Vector3 position;
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
            position = cameraObj.ScreenToViewportPoint(Input.mousePosition);
            transform.position = position;
        }
    }
    public void OnMouseUp()
    {
        draggable = false;
    }
}