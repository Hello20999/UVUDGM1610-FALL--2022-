using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Consistente movement.  Based on elapse time between framerate
public class TimeByElapse : MonoBehaviour
{
    public float distancePerSecond;
    void Update()
    {
        transform.Translate(0, 0, distancePerSecond * Time.deltaTime);
    }
}
