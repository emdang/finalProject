using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recordColor : MonoBehaviour {
    public MeshRenderer mR;
    public Material newMaterial;
    // Use this for initialization
    void Start () {
        mR.material = newMaterial;
    }
	
}
