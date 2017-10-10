using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawn : MonoBehaviour { 


    public GameObject Background;
    public Transform BackgroundSpawnplace;
    [SerializeField]
    private float spawntime = 3;
    private float nextBackground;
	
	// Update is called once per frame
	void Update()
   {
       Vector2 position = new Vector2(BackgroundSpawnplace.position.x, 0);
       if (Time.time > nextBackground)
       {
            nextBackground = Time.time + spawntime;
           Instantiate(Background, position, BackgroundSpawnplace.rotation);
       }
   }
}