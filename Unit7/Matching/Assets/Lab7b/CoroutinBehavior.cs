using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutinBehavior : MonoBehaviour
{
    public bool canRun = true;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        
        Debug.Log("Start");
        yield return new WaitForSeconds(3);
        Debug.Log("Last Start");
        while (canRun)
        {
            yield return new WaitForFixedUpdate();
            Debug.Log("Run on start");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Run");
    }
}
