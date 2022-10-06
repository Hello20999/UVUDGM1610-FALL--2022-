using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpole : MonoBehaviour
{
    //get a vlaue beteween two numbers
    float result = Mathf.Lerp(3f, 5f, 0.5f);

    //using three vector 3 for value
    //From, to have an error
    /*
    Vector3 from = new Vector3(1f, 2f, 3f);
    Vector3 to = new Vector3(5f, 6f, 7f);
    Vector3 something = Vector3.Lerp(from, to, 0.75f);
    */

    //changing values
    /*
    void Update()
    {
        light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f);
    }
    */
    //add time to the change
    /*{
        light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f * Time.deltaTime);
    }*/
}
