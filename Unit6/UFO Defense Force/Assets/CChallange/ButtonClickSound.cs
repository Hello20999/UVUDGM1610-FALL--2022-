using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSoundEffect : MonoBehaviour
{
    bool music;
    private void Awake()
    {
        music = false;
    }
    private void Update()
    {
        if (music == true)
        {
            Debug.Log("works");
            music = false;
        }
    }
}
