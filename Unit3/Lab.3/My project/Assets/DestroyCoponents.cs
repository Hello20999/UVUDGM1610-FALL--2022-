using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoponents : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(GetComponent<MeshRenderer>());
        }
    }
    //used to destory elements of the object, but not everything
}
