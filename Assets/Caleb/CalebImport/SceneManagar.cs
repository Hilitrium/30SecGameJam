using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagar : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("scene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
	

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
