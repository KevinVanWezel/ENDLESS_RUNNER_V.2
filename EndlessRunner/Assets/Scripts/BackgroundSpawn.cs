using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawn : MonoBehaviour {

    public GameObject Background;
    public Transform BackgroundSpawnplace;
    public Vector2 min;
    public Vector2 max;
    public GameObject currentBackground;
	
    void Start()
    {
        min = currentBackground.GetComponent<SpriteRenderer>().bounds.min;
        max = currentBackground.GetComponent<SpriteRenderer>().bounds.max;
    }
	void Update()
   {
        GameObject[] achtergronden = GameObject.FindGameObjectsWithTag("Background");
        currentBackground = achtergronden[achtergronden.Length - 1];
        Vector2 position = new Vector2(currentBackground.transform.position.x + max.x * 2 - 0.05f, 0);
        if (currentBackground.GetComponent<SpriteRenderer>().bounds.min.x >= min.x - 0.5 && currentBackground.GetComponent<SpriteRenderer>().bounds.min.x <= min.x + 0.5)
        {
            Instantiate(Background, position, BackgroundSpawnplace.rotation);
        }
   }
}