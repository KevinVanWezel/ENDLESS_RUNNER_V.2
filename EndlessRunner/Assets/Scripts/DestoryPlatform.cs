using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryPlatform : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if(this.transform.position.x <= -21)
        {
            //Debug.Log("Bang");
            Destroy(this.gameObject);
        }
	}
}
