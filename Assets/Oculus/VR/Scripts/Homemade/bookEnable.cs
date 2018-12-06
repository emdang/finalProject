using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookEnable : MonoBehaviour {
    public GameObject pin;
	// Use this for initialization
	void Start () {
     //   gameObject.GetComponent<Collider>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (pin.GetComponent<pickedScript>().picked = true)
        {
            gameObject.GetComponent<Collider>().enabled = true;
        }
	}
}
