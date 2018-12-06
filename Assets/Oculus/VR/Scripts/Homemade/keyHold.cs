using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyHold : MonoBehaviour {
    public Collider handCollider;
    public Collider lockCollider;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other = handCollider)
            lockCollider.enabled=true;
    }
    private void OnTriggerExit(Collider other)
    {
        lockCollider.enabled = false;
    }
}
