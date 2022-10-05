using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syntax : MonoBehaviour
{
    void Start()
    {
        //single line comment

        /*Multi line comment
        well keep going
        Until it ends with same way it starts*/
        Debug.Log(transform.position.x);
        //this is a map for information to get access, like a address

        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }
}
