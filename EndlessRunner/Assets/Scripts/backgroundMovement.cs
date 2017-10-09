using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMovement : MonoBehaviour
{

    private GameObject data;
    private DataBackground thedata;
    private Rigidbody2D rb2d;
    private bool check = true;
    
    private float mySpeed;
	// Use this for initialization
	void Start()
    {
        data = GameObject.FindGameObjectWithTag("TheData");
        thedata = data.GetComponent<DataBackground>();
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update()
    {
        if (check == true)
        {
            mySpeed = thedata.Speed;
            check = false;
        }
        Vector2 direction = (Vector2.left) * mySpeed * Time.fixedDeltaTime;
        rb2d.MovePosition(rb2d.position + direction);
    }
}