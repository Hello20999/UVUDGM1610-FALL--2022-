using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAndAwake : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Awake called.");
    }
    //Loads before script is enabled
    void Start()
    {
        Debug.Log("Start called.");
    }
    //loads once script is enabled, but before the first update
    //both will only be used once
}
