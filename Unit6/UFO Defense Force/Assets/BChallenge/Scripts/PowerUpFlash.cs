using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpFlash : MonoBehaviour
{
    public Material Purple;
    public Material Green;
    private float time = 1.4f;
    void Update()
    {
        time -= Time.deltaTime;
        if (time < 1.2)
        {
            this.gameObject.GetComponent<MeshRenderer>().material = Purple;
        }
        if (time < 1)
        {
            this.gameObject.GetComponent<MeshRenderer>().material = Green;
            time = 1.4f;
        }
    }
}
