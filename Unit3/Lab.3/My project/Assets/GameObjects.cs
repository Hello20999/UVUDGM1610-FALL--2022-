using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjects : MonoBehaviour
{
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        //how to access another script on the same object
        /* 
         * how to change a variable within another file
         * Change the mass of the object's Rigidbody.
            */
        rb.mass = 10f;
        /* Add a force to the Rigidbody.
         * how to referecne another file on the same object
         */
        rb.AddForce(Vector3.up * 10f);

    }
    public class Chef : MonoBehaviour
        //how to refrence another object
    {
        public GameObject stove;
        void Start()
        {
            // how to change another object from current object
            transform.position = stove.transform.position + Vector3.forward * 2f;
        }
            public Transform playerTransform;
            //how to access a component directly
    }
}