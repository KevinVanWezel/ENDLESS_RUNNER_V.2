using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    private GameObject data;
    private DataEnemy thedata;
    private Rigidbody2D rb2d;
    private bool check = true;
    private float mySpeed;

	void Start () {
        data = GameObject.FindGameObjectWithTag("TheData");
        thedata = data.GetComponent<DataEnemy>();
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	void Update () {
        if(check == true)
        {
            mySpeed = thedata.Speed;
            check = false;
        }
        Vector2 direction = (Vector2.left) * mySpeed * Time.fixedDeltaTime;
        rb2d.MovePosition(rb2d.position + direction);
    }
}
