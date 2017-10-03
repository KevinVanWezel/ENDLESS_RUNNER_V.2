using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryPastPoint : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if(this.transform.position.x <= -25)
        {
            Destroy(this.gameObject);
        }
	}
}
