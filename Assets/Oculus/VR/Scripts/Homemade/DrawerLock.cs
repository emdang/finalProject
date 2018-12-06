using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(OVRGrabbable))]
public class DrawerLock : MonoBehaviour {
    public OVRGrabbable grabScript;
    Vector3 temp;
	// Use this for initialization
	void Awake () {
        grabScript = GetComponent<OVRGrabbable>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (grabScript.isGrabbed)
            print("grabbed");
	}
}
