using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckStatus1 : MonoBehaviour
{
    public GameObject myObject;
    void Start()
    {
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);
    }
    //how to check if obj active
}
