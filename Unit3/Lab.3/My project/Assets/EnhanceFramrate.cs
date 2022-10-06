using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnhanceFramrate : MonoBehaviour
{
    string folder = "ScreenshotFolder";
    int frameRate = 25;
    void Start()
        //how to seet the framerate for recording
    { 
        Time.captureFramerate = frameRate;
        System.IO.Directory.CreateDirectory(folder);
    }
    void Update()
    {
        //how to store screenshot
        string name = string.Format("{0}/{1:D04} shot.png", folder, Time.frameCount);
        //Application.CaptureScreenshot(name);
    }
}
