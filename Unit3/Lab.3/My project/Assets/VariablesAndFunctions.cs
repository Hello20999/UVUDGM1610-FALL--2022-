using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int myInt = 10;
    //creating a variable, nothing new
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
        //equation to set new value
    }
    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 3;
        return result;
        //creation of temporary variable to perform operations
    }
}
