using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour {

    public Datas data;
    private Rigidbody2D rb2d;
    private bool check = true;

    [SerializeField]
    private float mySpeed;
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if(check == true)
        {
            mySpeed = data.Speed;
            check = false;
        }
        Vector2 direction = (Vector2.left) * mySpeed * Time.fixedDeltaTime;
        rb2d.MovePosition(rb2d.position + direction);
        Debug.Log(mySpeed);
    }
}
