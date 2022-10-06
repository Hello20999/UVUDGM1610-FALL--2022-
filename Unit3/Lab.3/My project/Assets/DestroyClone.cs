using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyClone : MonoBehaviour
{
    //destroys a clone after a certain ammount of time
    void Start()
    {
        Destroy(gameObject, 1.5f);
    }
}
