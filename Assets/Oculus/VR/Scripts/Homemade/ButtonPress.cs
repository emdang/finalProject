using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour {
    public Collider ButtCollider;
    public Animator anim;
    public Animation clip;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("BUTT TOUCHED");
            anim.SetTrigger("ButtonTrigger");
            anim.SetBool("RecordFinished", false);
        }
        if (!clip.IsPlaying("recordAnimation"))
        {
            anim.SetBool("RecordFinished", true);
            Invoke("ChangeColorTrigger", 1);
        }
    }
}
