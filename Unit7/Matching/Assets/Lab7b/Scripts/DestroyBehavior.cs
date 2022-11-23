using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBehavior : MonoBehaviour
{
    public float second = 1;
    private WaitForSeconds wfsObj;
    IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(second);
        yield return wfsObj;
        Destroy(gameObject);

    }
}
