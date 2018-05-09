using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour {


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Victory();
        }
    }

    public void Victory()
    {
        SceneManager.LoadScene("Checkpoint");
    } 
}
