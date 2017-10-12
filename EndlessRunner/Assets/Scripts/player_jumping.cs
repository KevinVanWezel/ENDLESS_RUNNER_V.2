using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_jumping : MonoBehaviour {

    public Pause stop;

	void Update () {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
            if (Input.GetKey(KeyCode.Space) && stop.stopEverything == false)
            {
                rb.AddForce(Vector2.up * 20);
            }
    }
}
