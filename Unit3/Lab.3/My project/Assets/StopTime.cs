using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//How to pause, or stop time
public class StopTime : MonoBehaviour
{
    void Pause()
    {
        Time.timeScale = 0;
    }
    void Resume()
    {
        Time.timeScale = 1;
    }
}
