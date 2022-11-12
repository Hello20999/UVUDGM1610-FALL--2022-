using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleSound : MonoBehaviour
{
    Sound sound;
    private void Awake()
    {
        sound = GameObject.Find("ButtonClickSound").GetComponent<Sound>();
    }
    public void RunSound()
    {
        sound.sound = true;
    }
}
