using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Datas : MonoBehaviour {

    public float Speed;
    private float Acceleration;
    private int cooldown;
    private int maxCooldown;
    // Use this for initialization
    void Start () {
        Speed = 2.5f;
        Acceleration = 0.1f;
        maxCooldown = 1000;
        cooldown = maxCooldown;
	}
	
	// Update is called once per frame
	void Update () {
        StartCoroutine("Test");
	}

    private IEnumerator Test()
    {
        while (true)
        {
            //Debug.Log(cooldown);
            if (cooldown > 0)
            {
                cooldown--;
            }
            else if (cooldown <= 0)
            {
                Speed += Acceleration;
                cooldown = maxCooldown;
                Debug.Log(Speed);
            }
            yield return new WaitForSeconds(200);
        }

    }
}
