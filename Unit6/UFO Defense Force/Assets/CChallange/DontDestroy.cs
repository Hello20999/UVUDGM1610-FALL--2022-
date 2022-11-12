using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    private static DontDestroy DontDestroyInstance;
    private void Awake()
    {
        DontDestroyOnLoad(this);
        if (DontDestroyInstance == null)
        {
            DontDestroyInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
