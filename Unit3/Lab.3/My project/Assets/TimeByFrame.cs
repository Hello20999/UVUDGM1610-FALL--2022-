using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Calculate movement base on framerate
public class TimeByFrame : MonoBehaviour
{
    public float distancePerFrame;
    void Update()
    {
        transform.Translate(0, 0, distancePerFrame); // this is incorrect
    }
}
