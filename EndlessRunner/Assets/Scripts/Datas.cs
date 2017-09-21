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
        Speed = 1;
        Acceleration = 1.5f;
        maxCooldown = 500;
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
            yield return new WaitForSeconds(10);
        }

    }
}
