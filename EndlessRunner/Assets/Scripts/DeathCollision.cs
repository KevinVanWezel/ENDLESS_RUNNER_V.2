using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCollision : MonoBehaviour {

    public bool end;
    // Use this for initialization
    void Start () {
        end = false;
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy" || other.tag == "Floor")
        {
            end = true;
            Time.timeScale = 0;
            SceneManager.LoadScene(2);
        }
    }
}
