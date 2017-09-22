using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryPlatform : MonoBehaviour {

    private Rigidbody2D rb2d;
    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if(this.transform.position.x <= -21)
        {
            //Debug.Log("Bang");
            Destroy(this.gameObject);
        }
	}
}
