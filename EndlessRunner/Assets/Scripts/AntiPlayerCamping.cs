using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiPlayerCamping : MonoBehaviour {

    public bool FocusShot = false;
    private Transform myself;
    private GameObject player;
    private bool inside = true;
    public float timer = 0;
	// Use this for initialization
	void Start () {
        myself = GetComponent<Transform>();
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(inside == true)
        {
            timer += Time.fixedDeltaTime;
            if(timer >= 5)
            {
                FocusShot = true;
            }
        }
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            inside = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            inside = false;
            timer = 0;
            myself.position = player.transform.position;
        }
    }
}
