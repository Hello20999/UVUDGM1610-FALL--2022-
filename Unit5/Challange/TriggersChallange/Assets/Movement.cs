using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    private void Start()
    {
        //transform.position = Vector3Data(dataOBJ);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(new Vector3(0f, 1f, 0f) * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(new Vector3(0f, -1f, 0f) * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(new Vector3(1f, 0f, 0f) * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(new Vector3(-1f, -0f, 0f) * moveSpeed * Time.deltaTime);
    }
}