using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float HorizontalInput;
    public float speed = 40;
    public float xRange = 35.6f;

    public Transform blaster;
    public GameObject Projectile;
    public GameManager gameManager;
    public string[] inventory = { "empty", "empty", "empty"};
    // Update is called once per frame
    private void Awake()
    {
        inventory[0] = "empty";
        inventory[1] = "empty";
        inventory[2] = "empty";
    }
    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Update()
    {
        //keyboard access
        HorizontalInput = Input.GetAxis("Horizontal");
        //movement right
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * speed);

        //keep player within screen
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //creates lazer bolt
        if (Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false)
        {
            Instantiate(Projectile, blaster.transform.position, Projectile.transform.rotation);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log(inventory[0] + " "+ inventory[1] + " " + inventory[2]);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy")) { }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
