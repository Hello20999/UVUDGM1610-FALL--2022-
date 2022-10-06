using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjWayPoint : MonoBehaviour
    //Retrieving children obj from parent obj
{
    public Transform[] waypoints;

    void Start()
    {
        waypoints = new Transform[transform.childCount];
        int i = 0;

        foreach (Transform t in transform)
        {
            waypoints[i++] = t;
        }
    }
}
