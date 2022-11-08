using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    private float time = 5;
    public float move = 5;
    public float speed = 30;
    public float xRange = 38;
    public Transform Spawner;
    public GameObject PowerUp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * move * Time.deltaTime * speed);
        if (transform.position.x < -xRange)
        {
            move = 5;
        }
        if (transform.position.x > xRange)
        {
            move = -5;
        }
        time -= Time.deltaTime;
        if (time < 0)
        {
            Instantiate(PowerUp, Spawner.transform.position, PowerUp.transform.rotation);
            time = Random.Range(10f , 20f);
        }
    }
}
