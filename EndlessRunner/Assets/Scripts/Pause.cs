using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public DeathCollision death;
    public bool stopEverything;
	// Use this for initialization
	void Start () {
        stopEverything = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (death.end == false)
        {
            if (Input.GetKeyDown(KeyCode.P) && stopEverything == false)
            {
                Time.timeScale = 0;
                stopEverything = true;
            } else if (Input.GetKeyDown(KeyCode.P) && stopEverything == true)
            {
                Time.timeScale = 1;
                stopEverything = false;
            }
        }
    }
}
