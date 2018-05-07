using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerController : MonoBehaviour {

    public float Timer;
    public Text CountDown;

	// Use this for initialization
	void Start ()
    {
        CountDown.text = "Time Left: " + Timer.ToString();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Timer -= Time.deltaTime;
        CountDown.text = "Time Left: " + Timer.ToString();
        if (Timer < 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("LossScene");
    }

}
