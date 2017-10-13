using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScore : MonoBehaviour {

    public int score;
	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
