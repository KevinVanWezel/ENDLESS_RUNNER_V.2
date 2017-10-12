using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryPastPoint : MonoBehaviour {
    [SerializeField]
    private float endpoint;
    
    public int ScoreValue;
    private EnemySpawner spawn;

    void Start()
    {
        spawn = GameObject.Find("EnemiesSpawner").GetComponent<EnemySpawner>();
    }

    void Update () {
        if(this.transform.position.x <= endpoint)
        {
            spawn.AddScore(ScoreValue);
            Destroy(this.gameObject);
        }
	}
}
