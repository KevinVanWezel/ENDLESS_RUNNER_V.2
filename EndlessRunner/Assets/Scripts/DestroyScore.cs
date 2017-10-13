using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScore : MonoBehaviour {

	public void Delete()
    {
        Destroy(GameObject.FindGameObjectWithTag("TheScore").gameObject);
    }
}
