using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedupdate : MonoBehaviour
{
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }
    //a fix timeline, wont change
    void Update()
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }
    //still on a timeline, but times are diffrent between intervals
}
