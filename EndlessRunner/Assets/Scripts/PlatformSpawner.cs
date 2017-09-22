﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour {

    public GameObject Platform;
    public Transform PlatformSpawnplace;
    private float spawntime = 3;
    private float nextPlatform;
	
	// Update is called once per frame
	void Update () {
        Vector2 position = new Vector2(PlatformSpawnplace.position.x, Random.Range(-4f, 3f));
        if (Time.time > nextPlatform)
        {
            nextPlatform = Time.time + spawntime;
            Instantiate(Platform, position, PlatformSpawnplace.rotation);
        }
	}
}
