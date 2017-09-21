using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour {

    public Datas data;
    private Rigidbody2D rb2d;

    //[SerializeField]
    private float mySpeed;
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        mySpeed = data.Speed;
        Debug.Log(mySpeed);
    }
	
	// Update is called once per frame
	void Update () {
        Vector2 direction = (Vector2.left) * mySpeed * Time.fixedDeltaTime;
        rb2d.MovePosition(rb2d.position + direction);
	}
}
