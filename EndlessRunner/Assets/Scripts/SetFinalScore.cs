using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetFinalScore : MonoBehaviour {

    public Text FinalScoreText;
    private MyScore myScore;

	// Use this for initialization
	void Start () {
        myScore = GameObject.FindGameObjectWithTag("TheScore").GetComponent<MyScore>();
        FinalScoreText.text = "Your Final Score is: " + myScore.score;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
