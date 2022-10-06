using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this destroy a itself after a short delay
        void OnCollisionEnter(Collision otherObj)
        {
            if (otherObj.gameObject.tag == "Garbage can")
            {
                Destroy(gameObject, 0.5f);
            }
        }
        Destroy(this);
        //this destroy the main obj and the cript attached to it
    }
}