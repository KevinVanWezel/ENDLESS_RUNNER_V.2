using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background_spawner : MonoBehaviour {

    public GameObject Background;
    private Transform[] mybackgrounds;
    public Transform BackgroundSpawnplace;
    private int wait;
	
    void Start ()
    {
        mybackgrounds = new Transform[1];
        mybackgrounds[0] = GameObject.FindGameObjectWithTag("Background").GetComponent<Transform>();
    }

	// Update is called once per frame
	void Update () {
        Vector2 position = new Vector2(BackgroundSpawnplace.position.x,0);
        mybackgrounds[0] = GameObject.FindGameObjectWithTag("Background").GetComponent<Transform>();
        wait--;
        if (mybackgrounds[0].transform.position.x <= 0.1f && mybackgrounds[0].transform.position.x >= -0.1f && wait <= 0)
        {
            Instantiate(Background, position, BackgroundSpawnplace.rotation);
            wait = 10;
        }

    }
}
