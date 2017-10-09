using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_jumping : MonoBehaviour {

    public Pause stop;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
            if (Input.GetKey(KeyCode.Space) && stop.stopEverything == false)
            {
                Debug.Log("Space");
                rb.AddForce(Vector2.up * 20);
            }
    }
}
