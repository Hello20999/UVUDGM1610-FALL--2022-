using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeDemetionanalOrintation : MonoBehaviour
{
    //how to oriontate an object in a three demensional plane
    float x;
    void Update()
    {
        x += Time.deltaTime * 10;
        transform.rotation = Quaternion.Euler(x, 0, 0);
    }
}
