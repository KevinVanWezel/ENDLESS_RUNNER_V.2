using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClosePanels : MonoBehaviour {

    public GameObject Open;
    public GameObject Close;

	public void Action()
    {
        Open.SetActive(true);
        Close.SetActive(false);
    }
}
