using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceVDataType : MonoBehaviour
{
    void Start()
    {
        //any change would have no effect on other objects
        Vector3 pos = transform.position;
        pos = new Vector3(0, 2, 0);

        //any change will effect all objects
        Transform tran = transform;
        tran.position = new Vector3(0, 2, 0);
    }
}
