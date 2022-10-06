using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOther : MonoBehaviour
{
    public GameObject other;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(other);
        }
    }
    //this is used to detroy another object than itself
}
