using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PowerUp : MonoBehaviour
{
    PlayerController playerController;
    GameObject player;
    private float time;
    public void Awake()
    {
        player = GameObject.Find("Player");
        playerController = player.GetComponent<PlayerController>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if (time < 0)
            {


                if (playerController.inventory[0] == "empty")
                {
                    playerController.inventory[0] = "fire";
                    Destroy(gameObject);
                    time = 4;
                }
                else if (playerController.inventory[1] == "empty")
                {
                    playerController.inventory[1] = "shield";
                    Destroy(gameObject);
                    time = 4;
                }
                else if (playerController.inventory[2] == "empty")
                {
                    playerController.inventory[2] = "lazer";
                    Destroy(gameObject);
                    time = 4;
                }
                else
                {
                    Debug.Log("Current inventory is full");
                    Destroy(gameObject);
                    time = 4;
                }
            }
        }
    }
    public void Update()
    {
        if(transform.position.z < -22)
        {
            Destroy(gameObject);
        }
        time -= Time.deltaTime;
    }
}
