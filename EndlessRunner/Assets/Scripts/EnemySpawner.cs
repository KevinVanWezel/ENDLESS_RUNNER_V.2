﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    
    public List<GameObject> Enemy;
    public Transform EnemySpawnplace;
    [SerializeField]
    private float spawntime = 3;
    private float nextPlatform;
    private float spawnbereik;

    // Update is called once per frame
    void Update () {
        spawnbereik = Random.Range(-4f, 4f);
        Vector3 position = new Vector3(EnemySpawnplace.position.x, spawnbereik, -1);
        if (Time.time > nextPlatform)
        {
            nextPlatform = Time.time + spawntime;
            if (spawnbereik <= -2f)
            {
                Instantiate(Enemy[2], position, EnemySpawnplace.rotation);
            }
            else
            {
                Instantiate(Enemy[Random.Range(0,2)], position, EnemySpawnplace.rotation);
            }
        }
	}
}
