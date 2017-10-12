using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMovement : MonoBehaviour
{
    
    private Rigidbody2D rb2d;
    private float Speed = 2.5f;

	void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	void Update()
    {
        Vector2 direction = (Vector2.left) * Speed * Time.deltaTime;
        rb2d.MovePosition(rb2d.position + direction);
    }
}