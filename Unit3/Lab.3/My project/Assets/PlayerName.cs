using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerName : MonoBehaviour
{
    public string myName;
    void Start()
    {
        Debug.log("I am alive and my name is " + myName);
    }

    //this is used to create an editable spot to input a name, in which will broadcast what you put.
}
