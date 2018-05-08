using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour {

    bool counterClockwise = false;
    public int speed;

	// Use this for initialization
	void Start () {
		if (counterClockwise)
        {
            speed = -speed;
        }
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
	}

}
