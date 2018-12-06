using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChangeTrigger : MonoBehaviour {
    //public Material startMaterial;
    public Material newMaterial;
    public Collider mc;
   // public GameObject obj;
    public MeshRenderer mR;

    
    // Use this for initialization
    void Start () {
      //  mR = obj.GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter(Collider other)
    {
        if (other == mc)
        {
            mR.material = newMaterial;
        }
    }
}
