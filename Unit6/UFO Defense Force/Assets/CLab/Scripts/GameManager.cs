using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    private GameObject gameOverText;
    public bool EnemySoundEffect;
    public AudioClip enemyBlowUp;
    public AudioClip buttonClicking;
    public AudioClip losingSoundEffect;
    private AudioSource audioSource;
    public bool buttonClick;
    public bool Losing;
    private void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
        EnemySoundEffect = false;
        buttonClick = true;
        Losing = false;
    }
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (isGameOver)       //no variable attached means it true
        {
            EndGame();
        }
        else
        {
            gameOverText.gameObject.SetActive(false);
        }
        if (EnemySoundEffect == true)
        {
            audioSource.PlayOneShot(enemyBlowUp, 1.0f);
            EnemySoundEffect = false;
        }
        if (buttonClick == true)
        {
            audioSource.PlayOneShot(buttonClicking, 1f);
            buttonClick = false;
        }
        if (Losing == true)
        {
            audioSource.PlayOneShot(losingSoundEffect, 1f);
            Losing = false;
        }
    }
    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
