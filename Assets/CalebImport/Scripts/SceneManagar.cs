using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagar : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("JLevel1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
	

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void NextMap()
    {
       SceneManager.LoadScene("CScene1");
    }
}
