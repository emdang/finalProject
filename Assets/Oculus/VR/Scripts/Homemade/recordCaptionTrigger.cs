using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recordCaptionTrigger : MonoBehaviour {
    public Animator anim;
    public AnimationClip aclip;
	// Use this for initialization
	void activateCaption (string caption) {
        anim.SetTrigger("captionActivated");
	}
}
