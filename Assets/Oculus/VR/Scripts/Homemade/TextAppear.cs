using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAppear: MonoBehaviour {//text in the clock only visible after the door is unlocked
    public MeshRenderer mR;
    public Collider mC;
    
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter(Collider other)
    {
        if (other=mC)
        {
           mR.enabled=true;
        }
    }
}
