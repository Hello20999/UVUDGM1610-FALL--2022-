using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjWayPoint : MonoBehaviour
    //A little confused, but I assume this is to create a way of locating this obj so the main obj can interact with it
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
