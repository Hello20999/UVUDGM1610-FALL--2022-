using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager; //reference script ScoreManager
    public int scoreToGive;
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();  //find component on gameobject
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Destroy"))
        {
            scoreManager.IncreaseScore(scoreToGive);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
