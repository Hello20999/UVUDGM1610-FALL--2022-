using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public int SceneToLoad;
    public void StartGame()
    {
        SceneManager.LoadScene(SceneToLoad);
        Debug.Log("Load scene!");
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game!");
    }
}
