using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawn : MonoBehaviour {

    public GameObject Background;
    public Transform BackgroundSpawnplace;
    [SerializeField]
    private float spawntime = 3;
    private float nextBackground;
    public Vector2 min;
    public Vector2 max;
    public GameObject currentBackground;
	
    void Start()
    {
        min = currentBackground.GetComponent<SpriteRenderer>().bounds.min;
        max = currentBackground.GetComponent<SpriteRenderer>().bounds.max;
    }
	// Update is called once per frame
	void Update()
   {
        currentBackground = GameObject.FindGameObjectWithTag("Background");
        Vector2 position = new Vector2(currentBackground.transform.position.x + max.x, 0);
        //use position to place new background.
        //if currentbackground < value
        // spawn new background
        //use sprite length to find new object position.


        if (currentBackground.GetComponent<SpriteRenderer>().bounds.min.x == min.x)
        {
            Instantiate(Background, position, BackgroundSpawnplace.rotation);
            min = currentBackground.GetComponent<SpriteRenderer>().bounds.min;
            max = currentBackground.GetComponent<SpriteRenderer>().bounds.max;
        }

        /*if (Time.time > nextBackground)
       {
            nextBackground = Time.time + spawntime;
           Instantiate(Background, position, BackgroundSpawnplace.rotation);
       }*/
   }
}