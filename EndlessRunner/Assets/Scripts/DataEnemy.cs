using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataEnemy : MonoBehaviour {

    public float Speed;
    private float Acceleration;
    private int cooldown;
    private int maxCooldown;
    public Pause stop;

    void Start () {
        Speed = 2.5f;
        Acceleration = 0.1f;
        maxCooldown = 1000;
        cooldown = maxCooldown;
	}

	void Update () {
        StartCoroutine("SpeedAcceleration");
	}

    private IEnumerator SpeedAcceleration()
    {
        while (stop.stopEverything == false)
        {
            if (cooldown > 0)
            {
                cooldown--;
            }
            else if (cooldown <= 0)
            {
                Speed += Acceleration;
                cooldown = maxCooldown;
            }
            yield return new WaitForSeconds(200);
        }

    }
}
