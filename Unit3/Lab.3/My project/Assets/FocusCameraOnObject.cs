using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusCameraOnObject : MonoBehaviour
{
    public Transform target;
    void Update()
    {
        transform.LookAt(target);
    }
    //put code on camera to make it focus on an object
}
