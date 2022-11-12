using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public int SceneToLoad;
    public void Menu()
    {
        SceneManager.LoadScene(SceneToLoad);
        Debug.Log("Load scene!");
        StartCoroutine(WGame());
    }
IEnumerator WGame()
    {
        yield return new WaitForSeconds(.4f);
        SceneManager.LoadScene(SceneToLoad);
        Debug.Log("Load scene!");
    }
}
