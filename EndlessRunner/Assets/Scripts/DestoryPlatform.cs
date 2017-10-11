using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryPlatform : MonoBehaviour {
    public int score = 0;
    public int ScoreValue;  
    public EnemySpawner spawn;

    void Start()
    {
        spawn = GameObject.Find("EnemiesSpawner").GetComponent<EnemySpawner>();
    }
	// Update is called once per frame
	void Update () {
        if(this.transform.position.x <= -21)
        {
            //Debug.Log("Bang");
            spawn.AddScore(ScoreValue);
            Destroy(this.gameObject);
            
        }
	}
}
