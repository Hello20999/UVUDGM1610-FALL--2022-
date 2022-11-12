using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public bool sound;
    public float time;
    public AudioClip clicking;
    private AudioSource audiosource;
    private void Awake()
    {
        sound = false;
        time = 0;
    }
    public void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        time -= Time.deltaTime;
        if (sound == true)
        {
            audiosource.PlayOneShot(clicking);
            Debug.Log("works");
            sound = false;
            time = 2;
        }
        if (time == 1)
        {
            Debug.Log("This is running");
            Destroy(gameObject);
        }
    }
}
