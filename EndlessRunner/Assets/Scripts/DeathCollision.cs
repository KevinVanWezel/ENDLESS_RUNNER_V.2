using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollision : MonoBehaviour {

    public bool end;
    // Use this for initialization
    void Start () {
        end = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy" || other.tag == "Floor")
        {
            end = true;
            Time.timeScale = 0;
            print("Game over player");
        }
    }
}
